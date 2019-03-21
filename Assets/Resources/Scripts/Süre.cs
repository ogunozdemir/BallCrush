using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Süre : MonoBehaviour 
{
	public Text zamanlayici;
	
	public static float time=1800;
	public int sure;
	
	void Update() 
	{
		time -= Time.deltaTime;
		sure = System.Convert.ToInt32 (time);

		int seconds;
		int minutes;

		minutes = sure/60;
		seconds = sure%60;


		zamanlayici.text = string.Format("{0:00} : {1:00}", minutes, seconds);

		if (sure == 0) 
		{
			Application.LoadLevel(7);
		}

	}
}