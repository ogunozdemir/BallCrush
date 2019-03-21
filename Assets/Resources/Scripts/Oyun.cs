using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Oyun : MonoBehaviour 
{
	public List<Top> toplar = new List<Top> ();
	public int gridGenislik;
	public int gridYukseklik;
	public GameObject topPrefab;
	public Top sonTop;
	public Vector3 top1Basla,top1Bitir,top2Basla,top2Bitir;
	public bool takas = false;
	public bool yanlisTakas = false;
	public Top top1,top2;
	public float baslamaZamani;
	public float takasOrani = 3;
	public int degisimMiktari = 3;
	public bool degisim= false;
	public Text skor;
	public static int puan = 0;
	public AudioClip patlamaSesi;
	
	
	// Use this for initialization
	void Start () 
	{
		if (Süre.time == 1800 || Süre.time == 1500 || Süre.time == 900) 
		{
			puan = 0;
		}

		for (int y=0; y<gridYukseklik; y++) 
		{
			for(int x=0 ; x<gridGenislik; x++)
			{
				GameObject t = Instantiate(topPrefab,new Vector3(x,y,0),Quaternion.identity)as GameObject;
				t.transform.parent = gameObject.transform;
				toplar.Add(t.GetComponent<Top>());
			}
		}
		
		gameObject.transform.position = new Vector3 (-2.5f, -2.5f, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (degisim) {
			for (int i=0; i<toplar.Count; i++) {
				if (toplar [i].degisim) {
					toplar [i].TopYarat ();
					toplar [i].transform.position = new Vector3 (
						toplar [i].transform.position.x,
						toplar [i].transform.position.y + 6,
						toplar [i].transform.position.z);
				}
			}
			degisim = false;
		} else if (takas) {
			topHareketi (top1, top1Bitir, top1Basla);
			topNegHareketi (top2, top2Bitir, top2Basla);
			if (Vector3.Distance (top1.transform.position, top1Bitir) < .1f || Vector3.Distance (top2.transform.position, top2Bitir) < .1f) {
				top1.transform.position = top1Bitir;
				top2.transform.position = top2Bitir;
				sonTop = null;
				takas = false;
				gecisFizigi (false);
				if (!yanlisTakas) {
					top1.seciliMi ();
					top2.seciliMi ();
					degisimKontrolu ();
				} else {
					yanlisTakas = false;
				}
			}
		} 
		else if (!oyunDurumunuBelirle ()) 
		{
			for (int i=0; i<toplar.Count; i++) 
			{
				yakindakiDegisimKontrolu (toplar [i]);
			}

			if (!oynamaIzni()) 
			{
				degisim=true;
				for(int i=0;i<toplar.Count;i++)
				{
					toplar[i].degisim=true;
				}
			}
		} 
	}

	public bool oyunDurumunuBelirle()
	{
		for (int i=0; i<toplar.Count; i++) 
		{
			if(toplar[i].transform.localPosition.y>4)
			{
				return true;
			}
			else if(toplar[i].GetComponent<Rigidbody>().velocity.y>.1f)
			{
				return true;
			}
		}

		return false;
	}
	
	public void degisimKontrolu()
	{
		List<Top> top1List = new List<Top> ();
		List<Top> top2List = new List<Top> ();
		
		degisimListesiOlustur (top1.kume, top1, top1.XKoordinat, top1.YKoordinat, ref top1List);
		degisimListesiDuzelt (top1, top1List);
		degisimListesiOlustur (top2.kume, top2, top2.XKoordinat, top2.YKoordinat, ref top2List);
		degisimListesiDuzelt (top2, top2List);

		if(!degisim) 
		{
			yanlisTakas = true;
			eskiPozisyonaDon();
		}
	}

	public void eskiPozisyonaDon()
	{
		top1Basla=top1.transform.position;
		top1Bitir=top2.transform.position;
		
		top2Basla=top2.transform.position;
		top2Bitir=top1.transform.position;
		
		baslamaZamani=Time.time;
		gecisFizigi(true);
		takas=true;
	}

	public void yakindakiDegisimKontrolu(Top t)
	{
		List<Top> topListesi = new List<Top> ();
		degisimListesiOlustur (t.kume, t, t.XKoordinat, t.YKoordinat, ref topListesi);
		degisimListesiDuzelt (t,topListesi);
	}
	
	public void degisimListesiOlustur(string kume,Top top,int XKoordinat, int YKoordinat,ref List<Top> degisimListesi)
	{
		if (top == null) 
		{
			return;
		} 
		
		else if (top.kume != kume) 
		{
			return;
		} 
		
		else if (degisimListesi.Contains (top)) 
		{
			return;
		} 
		
		else 
		{
			degisimListesi.Add(top);
			
			if (XKoordinat == top.XKoordinat || YKoordinat == top.YKoordinat)
			{
				foreach (Top t in top.Komsular) 
				{
					degisimListesiOlustur (kume, t, XKoordinat, YKoordinat, ref degisimListesi);
				}
			}
		}
	}

	public bool oynamaIzni()
	{
		gecisFizigi (true);

		for (int i=0; i<toplar.Count; i++) 
		{
			for(int j=0; j<toplar.Count;j++)
			{
				if(toplar[i].KomsuIle(toplar[j]))
				{
					Top t=toplar[i];
					Top f=toplar[j];
					Vector3 tGecici = t.transform.position;
					Vector3 fGecici = f.transform.position;
					List<Top> geciciKomsular = new List<Top>(t.Komsular);

					t.transform.position= fGecici;
					f.transform.position= tGecici;

					t.Komsular=f.Komsular;
					f.Komsular=geciciKomsular;

					List<Top> testListesiT = new List<Top>();
					degisimListesiOlustur(t.kume,t,t.XKoordinat,t.YKoordinat,ref testListesiT);
					if(degisimListesiTesti(t,testListesiT))
					{
						t.transform.position = tGecici;
						f.transform.position = fGecici;
						f.Komsular = t.Komsular;
						t.Komsular = geciciKomsular;
						gecisFizigi (false);
						return true;
					}

					List<Top> testListesiF = new List<Top>();
					degisimListesiOlustur(f.kume,f,f.XKoordinat,f.YKoordinat,ref testListesiF);
					if(degisimListesiTesti(f,testListesiF))
					{
						t.transform.position = tGecici;
						f.transform.position = fGecici;
						f.Komsular = t.Komsular;
						t.Komsular = geciciKomsular;
						gecisFizigi (false);
						return true;
					}

					t.transform.position = tGecici;
					f.transform.position = fGecici;
					f.Komsular = t.Komsular;
					t.Komsular = geciciKomsular;
					gecisFizigi (false);

				}
			}
		}
		return false;
	}
	
	public bool degisimListesiTesti(Top top,List<Top> duzeltmeListesi)
	{
		List<Top> satir = new List<Top> ();
		List<Top> sutun = new List<Top> ();
		
		for (int i=0; i<duzeltmeListesi.Count; i++) 
		{
			if(top.XKoordinat == duzeltmeListesi[i].XKoordinat)
			{
				satir.Add(duzeltmeListesi[i]);
			}
			if(top.YKoordinat == duzeltmeListesi[i].YKoordinat)
			{
				sutun.Add(duzeltmeListesi[i]);
			}
		}
		
		if (satir.Count >= degisimMiktari) 
		{
			return true;
		}
		
		if (sutun.Count >= degisimMiktari) 
		{
			return true;
		}

		return false;
		
	}

	public void degisimListesiDuzelt(Top top,List<Top> duzeltmeListesi)
	{
		List<Top> satir = new List<Top> ();
		List<Top> sutun = new List<Top> ();
		
		for (int i=0; i<duzeltmeListesi.Count; i++) 
		{
			if(top.XKoordinat == duzeltmeListesi[i].XKoordinat)
			{
				satir.Add(duzeltmeListesi[i]);
			}
			if(top.YKoordinat == duzeltmeListesi[i].YKoordinat)
			{
				sutun.Add(duzeltmeListesi[i]);
			}
		}
		
		if (satir.Count >= degisimMiktari) 
		{
			puan++;
			skor.text = puan.ToString();
			GetComponent<AudioSource>().PlayOneShot(patlamaSesi, 0.8f);

			degisim = true;

			for(int i=0;i< satir.Count; i++)
			{
				satir[i].degisim = true;
			}
		}
		
		if (sutun.Count >= degisimMiktari) 
		{
			puan++;
			skor.text = puan.ToString();
			GetComponent<AudioSource>().PlayOneShot(patlamaSesi, 0.8f);

			degisim = true;

			for(int i=0;i< sutun.Count; i++)
			{
				sutun[i].degisim = true;
			}
		}
		
	}
	
	public void topHareketi(Top gemToMove,Vector3 toPos,Vector3 fromPos)
	{
		Vector3 center = (fromPos + toPos) * .5f;
		center -= new Vector3 (0, 0, .1f);
		Vector3 riseRelCenter = fromPos - center;
		Vector3 setRelCenter = toPos - center;
		float fracComplete = (Time.time - baslamaZamani)*takasOrani;
		gemToMove.transform.position = Vector3.Slerp (riseRelCenter, setRelCenter, fracComplete);
		gemToMove.transform.position += center;
	}
	
	public void topNegHareketi(Top gemToMove,Vector3 toPos,Vector3 fromPos)
	{
		Vector3 center = (fromPos + toPos) * .5f;
		center -= new Vector3 (0, 0, -.1f);
		Vector3 riseRelCenter = fromPos - center;
		Vector3 setRelCenter = toPos - center;
		float fracComplete = (Time.time - baslamaZamani)*takasOrani;
		gemToMove.transform.position = Vector3.Slerp (riseRelCenter, setRelCenter, fracComplete);
		gemToMove.transform.position += center;
	}
	
	public void gecisFizigi(bool isOn)
	{
		for (int i=0; i<toplar.Count; i++) 
		{
			toplar[i].GetComponent<Rigidbody>().isKinematic = isOn;
			
		}
	}
	
	public void topDegistir(Top seciliTop)
	{
		if (sonTop == null) 
		{
			sonTop = seciliTop;
		} 
		else if (sonTop == seciliTop) 
		{
			sonTop = null;
		} 
		else 
		{
			if(sonTop.KomsuIle(seciliTop))
			{
				top1Basla=sonTop.transform.position;
				top1Bitir=seciliTop.transform.position;
				
				top2Basla=seciliTop.transform.position;
				top2Bitir=sonTop.transform.position;
				
				baslamaZamani=Time.time;
				gecisFizigi(true);
				
				top1=sonTop;
				top2=seciliTop;
				takas=true;
			}
			else
			{
				sonTop.seciliMi();
				sonTop=seciliTop;
			}
		}
	}
	
}
