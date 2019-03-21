using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;

public class Skorlar : MonoBehaviour 
{
	public static string[] skorlar = {"0","0","0"};
	public Text skor1;
	public Text skor2;
	public Text skor3;

	void Start () 
	{

	}

	void Update () 
	{
		StreamReader oku = File.OpenText ("Assets/Resources/Skorlar/Skorlar.txt");
		
		for (int i=0; i<3; i++) 
		{
			skorlar[i]= oku.ReadLine();
		}
		
		oku.Close();
		
		skor1.text= skorlar[0];
		skor2.text= skorlar[1];
		skor3.text= skorlar[2];
		
		if (Oyun.puan > System.Convert.ToInt32 (skorlar [0]) && Oyun.puan > System.Convert.ToInt32 (skorlar [1]) && Oyun.puan > System.Convert.ToInt32 (skorlar [2])) 
		{
			StreamWriter yaz = new StreamWriter ("Assets/Resources/Skorlar/Skorlar.txt");
			yaz.WriteLine(Oyun.puan);
			yaz.WriteLine(skorlar[0]);
			yaz.WriteLine(skorlar[1]);
			yaz.Close();
		}
		if (Oyun.puan < System.Convert.ToInt32 (skorlar [0]) && Oyun.puan > System.Convert.ToInt32 (skorlar [1]) && Oyun.puan > System.Convert.ToInt32 (skorlar [2])) 
		{
			StreamWriter yaz = new StreamWriter ("Assets/Resources/Skorlar/Skorlar.txt");
			yaz.WriteLine(skorlar[0]);
			yaz.WriteLine(Oyun.puan);
			yaz.WriteLine(skorlar[1]);
			yaz.Close();
		}
		if (Oyun.puan < System.Convert.ToInt32 (skorlar [0]) && Oyun.puan < System.Convert.ToInt32 (skorlar [1]) && Oyun.puan > System.Convert.ToInt32 (skorlar [2])) 
		{
			StreamWriter yaz = new StreamWriter ("Assets/Resources/Skorlar/Skorlar.txt");
			yaz.WriteLine(skorlar[0]);
			yaz.WriteLine(skorlar[1]);
			yaz.WriteLine(Oyun.puan);
			yaz.Close();
		}
	}
}
