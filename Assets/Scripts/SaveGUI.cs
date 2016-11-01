using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGUI : MonoBehaviour
{

	public void OnGUI ()
	{
		if (GUI.Button (new Rect (20, 20, 200, 50), "Save RedCube")) {
			PlayerPrefs.SetString ("CUBE", "Cube/RedCube");
		}
		if (GUI.Button (new Rect (20, 80, 200, 50), "Save BlueCube")) {
			PlayerPrefs.SetString ("CUBE", "Cube/BlueCube");
		}
		if (GUI.Button (new Rect (20, 140, 200, 50), "Save GreenCube")) {
			PlayerPrefs.SetString ("CUBE", "Cube/GreenCube");
		}
		if (GUI.Button (new Rect (20, 200, 200, 50), "Save YellowCube")) {
			PlayerPrefs.SetString ("CUBE", "Cube/YellowCube");
		}
	}

}
