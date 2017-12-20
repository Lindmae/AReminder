using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadInformation : MonoBehaviour {

	public static void loadAllInformation(){
		GameInformation.name = PlayerPrefs.GetString ("playerName");
		GameInformation.color = PlayerPrefs.GetInt ("playerColor");

		GameInformation.isActive1 = PlayerPrefs.GetInt ("noteState1");
		GameInformation.isActive2 = PlayerPrefs.GetInt ("noteState2");
		GameInformation.isActive3 = PlayerPrefs.GetInt ("noteState3");
		GameInformation.isActive4 = PlayerPrefs.GetInt ("noteState4");

		GameInformation.reminder1 = PlayerPrefs.GetString ("note1");
		GameInformation.reminder2 = PlayerPrefs.GetString ("note2");
		GameInformation.reminder3 = PlayerPrefs.GetString ("note3");
		GameInformation.reminder4 = PlayerPrefs.GetString ("note4");

		Debug.Log ("Loaded: " + GameInformation.name);
	}
}
