using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);

		loadInformation.loadAllInformation ();
	}
	
	public static string name { get; set;}
	public static int color { get; set;}

	public static int isActive1 { get; set;}
	public static int isActive2 { get; set;}
	public static int isActive3 { get; set;}
	public static int isActive4 { get; set;}

	public static string reminder1 { get; set;}
	public static string reminder2 { get; set;}
	public static string reminder3 { get; set;}
	public static string reminder4 { get; set;}

	void OnApplicationQuit()
	{
		saveInformation.saveAllInformation ();
		PlayerPrefs.Save();
	}

	void OnApplicationPause(){
		saveInformation.saveAllInformation ();
		PlayerPrefs.Save();
	}
}


