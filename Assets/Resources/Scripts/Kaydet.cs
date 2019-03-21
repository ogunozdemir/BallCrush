using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class Kaydet : MonoBehaviour 
{

	public Text kullanici;
	string[] kullaniciBilgileri= {"-","-","-","-"};
	
	void Start () 
	{

	}

	void Update () 
	{

	}

	public void kayit(int buton)
	{
		if (buton == 1) 
		{
			StreamWriter yaz = new StreamWriter ("Assets/Resources/Oyuncular/Oyuncu1.txt");

			kullaniciBilgileri[0] = kullanici.text;
			kullaniciBilgileri[1] = (Top.level).ToString();
			kullaniciBilgileri[2] = System.Convert.ToInt32(Süre.time).ToString();
			kullaniciBilgileri[3] = (Oyun.puan).ToString();

			yaz.WriteLine(kullaniciBilgileri[0]);
			yaz.WriteLine(kullaniciBilgileri[1]);
			yaz.WriteLine(kullaniciBilgileri[2]);
			yaz.WriteLine(kullaniciBilgileri[3]);

			yaz.Close();

		}

		if (buton == 2) 
		{
			StreamWriter yaz = new StreamWriter ("Assets/Resources/Oyuncular/Oyuncu2.txt");
			
			kullaniciBilgileri[0] = kullanici.text;
			kullaniciBilgileri[1] = (Top.level).ToString();
			kullaniciBilgileri[2] = System.Convert.ToInt32(Süre.time).ToString();
			kullaniciBilgileri[3] = (Oyun.puan).ToString();
			
			yaz.WriteLine(kullaniciBilgileri[0]);
			yaz.WriteLine(kullaniciBilgileri[1]);
			yaz.WriteLine(kullaniciBilgileri[2]);
			yaz.WriteLine(kullaniciBilgileri[3]);
			
			yaz.Close();
			
		}
	}
}
