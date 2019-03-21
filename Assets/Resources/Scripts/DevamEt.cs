using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class DevamEt : MonoBehaviour 
{
	public static string[] oyuncular = {"-","-"};
	public Text oyuncu1;
	public Text oyuncu2;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		StreamReader oku1 = File.OpenText ("Assets/Resources/Oyuncular/Oyuncu1.txt");
		oyuncular[0]= oku1.ReadLine();
		oku1.Close();
		
		StreamReader oku2 = File.OpenText ("Assets/Resources/Oyuncular/Oyuncu2.txt");
		oyuncular[1]= oku2.ReadLine();
		oku2.Close();
		
		oyuncu1.text= oyuncular[0];
		oyuncu2.text= oyuncular[1];
	}

	public void devam(int buton)
	{
		if (buton == 1) 
		{
			string[] oyuncuBilgileri = {"level","sure","skor"};
			StreamReader oku = File.OpenText ("Assets/Resources/Oyuncular/Oyuncu1.txt");

			oku.ReadLine();

			for(int i=0;i<3;i++)
			{
				oyuncuBilgileri[i]= oku.ReadLine();
			}

			oku.Close();

			Oyun.puan = System.Convert.ToInt32(oyuncuBilgileri[2]);
			Süre.time = System.Convert.ToInt32(oyuncuBilgileri[1]);

			if(oyuncuBilgileri[0]=="1")
			{
				Top.level=1;
				Application.LoadLevel(3);
			}
			if(oyuncuBilgileri[0]=="2")
			{
				Top.level=2;
				Application.LoadLevel(4);
			}
			if(oyuncuBilgileri[0]=="3")
			{
				Top.level=3;
				Application.LoadLevel(5);
			}

		}

		if (buton == 2) 
		{
			string[] oyuncuBilgileri = {"level","sure","skor"};
			StreamReader oku = File.OpenText ("Assets/Resources/Oyuncular/Oyuncu2.txt");
			
			oku.ReadLine();
			
			for(int i=0;i<3;i++)
			{
				oyuncuBilgileri[i]= oku.ReadLine();
			}
			
			oku.Close();
			
			Oyun.puan = System.Convert.ToInt32(oyuncuBilgileri[2]);
			Süre.time = System.Convert.ToInt32(oyuncuBilgileri[1]);

			if(oyuncuBilgileri[0]=="1")
			{
				Top.level=1;
				Application.LoadLevel(3);
			}
			if(oyuncuBilgileri[0]=="2")
			{
				Top.level=2;
				Application.LoadLevel(4);
			}
			if(oyuncuBilgileri[0]=="3")
			{
				Top.level=3;
				Application.LoadLevel(5);
			}
				
			

			
		}
	}
}
