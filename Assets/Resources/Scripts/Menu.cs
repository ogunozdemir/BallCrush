using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	public void menu (int buton) 
	{
		if (buton == 0) 
		{
			Application.LoadLevel(0);
		}
		if (buton == 1) 
		{
			Application.LoadLevel(1);
		}
		if (buton == 2) 
		{
			Application.LoadLevel(2);
		}
		if (buton == 3) 
		{
			Top.level=1;
			Süre.time = 1800;
			Application.LoadLevel(3);
		}
		if (buton == 4) 
		{
			Top.level=2;
			Süre.time = 1500;
			Application.LoadLevel(4);
		}
		if (buton == 5) 
		{
			Top.level=3;
			Süre.time = 900;
			Application.LoadLevel(5);
		}
		if (buton == 6) 
		{
			Application.LoadLevel(6);
		}
		if (buton == 7) 
		{
			Application.LoadLevel(7);
		}
		if (buton == 8) //KAYDET
		{
			Application.LoadLevel(8);
		}
		if (buton == 9) 
		{
			Application.LoadLevel(9);
		}
		if (buton == 15)
		{
			Application.Quit();
		}

	}
}
