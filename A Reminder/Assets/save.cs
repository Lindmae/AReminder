using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;


[System.Serializable]
public class PlayerValues{
	public string name = "Me";
	public int color = 0;

	//one for each image target
	public bool active1 = false;
	public bool active2 = false;
	public bool active3 = false;
	public bool active4 = false;

	public string reminder1 = "";
	public string reminder2 = "";
	public string reminder3 = "";
	public string reminder4 = "";


}

public class save : MonoBehaviour {

	private PlayerValues playerValues;
	public GameObject note1;
	public GameObject note2;
	public GameObject note3;
	public GameObject note4;

	// Use this for initialization
	void Start () {
		LoadPlayerValues ();
	}

	private void LoadPlayerValues(){
		XmlSerializer serializer = new XmlSerializer(typeof(PlayerValues));
		string text = PlayerPrefs.GetString("player values");
		if (text.Length == 0) {
			playerValues = new PlayerValues ();
		} else {
			using (var reader = new System.IO.StringReader (text)) {
				playerValues = serializer.Deserialize (reader) as PlayerValues;
			}
		}
	}

	private void SavePlayerValues(){
		XmlSerializer serializer = new XmlSerializer(typeof(PlayerValues));
		using (StringWriter sw = new StringWriter ()) {
			serializer.Serialize (sw, playerValues);
			PlayerPrefs.SetString ("player values", sw.ToString());
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(note1.activeSelf){
			playerValues.active1 = true;
		}
		/*
		if(note2.activeSelf == true){
			playerValues.active2 = true;
		}
		if(note3.activeSelf == true){
			playerValues.active3 = true;
		}
		if(note4.activeSelf == true){
			playerValues.active4 = true;
		}


		if(note1.activeSelf == false){
			playerValues.active1 = false;
		}
		if(note2.activeSelf == true){
			playerValues.active2 = false;
		}
		if(note3.activeSelf == true){
			playerValues.active3 = false;
		}
		if(note4.activeSelf == true){
			playerValues.active4 = false;
		}*/

		SavePlayerValues ();
	}
}
