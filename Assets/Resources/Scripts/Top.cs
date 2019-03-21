using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Top : MonoBehaviour 
{
	public GameObject top;
	public GameObject secici;
	public List<Top> Komsular = new List<Top>();
	public string kume="";
	public bool secim= false;
	public bool degisim= false;
	public Text siyah;
	public Text beyaz;
	public static int level;

	public int XKoordinat
	{
		get
		{
			return Mathf.RoundToInt(transform.localPosition.x);
		}
	}

	public int YKoordinat
	{
		get
		{
			return Mathf.RoundToInt(transform.localPosition.y);
		}
	}

	// Use this for initialization
	void Start () 
	{
		TopYarat ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void seciliMi()
	{
		secim = !secim;
		secici.SetActive(secim);
	}

	public void TopYarat()
	{
		if (level == 1) 
		{
			int sayi = Random.Range (0, 142);
			
			double r = KMeans.X [sayi];
			double g = KMeans.Y [sayi];
			double b = KMeans.Z [sayi];
			
			if (KMeans.kume1.Contains (sayi)) 
			{
				kume = "kume1";
				siyah.text = "A";
				beyaz.text = "A";
			} else if (KMeans.kume2.Contains (sayi)) 
			{
				kume = "kume2";
				siyah.text = "B";
				beyaz.text = "B";
			} else if (KMeans.kume3.Contains (sayi)) 
			{
				kume = "kume3";
				siyah.text = "C";
				beyaz.text = "C";
			}
			
			Color32 renk = new Color32 ();
			renk.r = System.Convert.ToByte (r);
			renk.g = System.Convert.ToByte (g);
			renk.b = System.Convert.ToByte (b);
			top.GetComponent<Renderer> ().material.color = renk;
			
			degisim = false;
		}

		if (level == 2) 
		{
			int sayi = Random.Range (0, 142);
			
			double r = KMeans.X [sayi];
			double g = KMeans.Y [sayi];
			double b = KMeans.Z [sayi];
			
			if (KMeans.kume1.Contains (sayi)) 
			{
				kume = "kume1";
				siyah.text = "A";
				beyaz.text = "A";
			} else if (KMeans.kume2.Contains (sayi)) 
			{
				kume = "kume2";
				siyah.text = "B";
				beyaz.text = "B";
			} else if (KMeans.kume3.Contains (sayi)) 
			{
				kume = "kume3";
				siyah.text = "C";
				beyaz.text = "C";
			} else if (KMeans.kume4.Contains (sayi)) 
			{
				kume = "kume4";
				siyah.text = "D";
				beyaz.text = "D";
			}
			
			Color32 renk = new Color32 ();
			renk.r = System.Convert.ToByte (r);
			renk.g = System.Convert.ToByte (g);
			renk.b = System.Convert.ToByte (b);
			top.GetComponent<Renderer> ().material.color = renk;
			
			degisim = false;
		}

		if (level == 3) 
		{
			int sayi = Random.Range (0, 142);
			
			double r = KMeans.X [sayi];
			double g = KMeans.Y [sayi];
			double b = KMeans.Z [sayi];
			
			if (KMeans.kume1.Contains (sayi)) 
			{
				kume = "kume1";
				siyah.text = "A";
				beyaz.text = "A";
			} 
			else if (KMeans.kume2.Contains (sayi)) 
			{
				kume = "kume2";
				siyah.text = "B";
				beyaz.text = "B";
			} 
			else if (KMeans.kume3.Contains (sayi)) 
			{
				kume = "kume3";
				siyah.text = "C";
				beyaz.text = "C";
			} 
			else if (KMeans.kume4.Contains (sayi)) 
			{
				kume = "kume4";
				siyah.text = "D";
				beyaz.text = "D";
			}
			else if (KMeans.kume5.Contains (sayi)) 
			{
				kume = "kume5";
				siyah.text = "E";
				beyaz.text = "E";
			}
			
			Color32 renk = new Color32 ();
			renk.r = System.Convert.ToByte (r);
			renk.g = System.Convert.ToByte (g);
			renk.b = System.Convert.ToByte (b);
			top.GetComponent<Renderer> ().material.color = renk;
			
			degisim = false;
		}


	}

	public void KomsuEkle (Top t)
	{
		if(!Komsular.Contains(t))
		Komsular.Add (t);
	}

	public bool KomsuIle(Top t)
	{
		if (Komsular.Contains (t)) 
		{
			return true;
		}

		return false;

	}

	public void KomsuKaldir(Top t)
	{
		Komsular.Remove (t);
	}

	void OnMouseDown()
	{
		/*if (GameObject.Find ("Oyun").GetComponent<Oyun> ().oyunDurumunuBelirle())
		{
			return;
		}*/
		if (!GameObject.Find ("Oyun").GetComponent<Oyun> ().takas) 
		{
			seciliMi ();
			GameObject.Find ("Oyun").GetComponent<Oyun> ().topDegistir (this);
		}
	}
}
