using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGUI : MonoBehaviour
{

	public void OnGUI ()
	{
		if (GUI.Button (new Rect (300, 20, 100, 50), "Load")) {
			string prefabPath = PlayerPrefs.GetString ("CUBE");
			GameObject prefab = Resources.Load (prefabPath) as GameObject;
			Instantiate (prefab, Vector3.zero, Quaternion.identity);
		}
	}


}
