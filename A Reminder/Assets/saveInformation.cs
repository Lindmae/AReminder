using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveInformation {

	public static void saveAllInformation(){
		PlayerPrefs.SetString ("playerName", GameInformation.name);
		PlayerPrefs.SetInt ("playerColor", GameInformation.color);

		PlayerPrefs.SetInt ("noteState1", GameInformation.isActive1);
		PlayerPrefs.SetInt ("noteState2", GameInformation.isActive2);
		PlayerPrefs.SetInt ("noteState3", GameInformation.isActive3);
		PlayerPrefs.SetInt ("noteState4", GameInformation.isActive4);

		PlayerPrefs.SetString ("note1", GameInformation.reminder1);
		PlayerPrefs.SetString ("note2", GameInformation.reminder2);
		PlayerPrefs.SetString ("note3", GameInformation.reminder3);
		PlayerPrefs.SetString ("note4", GameInformation.reminder4);
	}
}
