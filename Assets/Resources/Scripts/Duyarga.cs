using UnityEngine;
using System.Collections;

public class Duyarga : MonoBehaviour 
{
	public Top sahip;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Top") 
		{
			sahip.KomsuEkle (c.GetComponent<Top> ());
		}
	}

	void OnTriggerExit(Collider c)
	{
		if (c.tag == "Top") 
		{
			sahip.KomsuKaldir (c.GetComponent<Top> ());
		}
	}
}
