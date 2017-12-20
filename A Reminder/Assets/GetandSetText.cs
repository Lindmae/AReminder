using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class GetandSetText : MonoBehaviour {


	public InputField reminder;

	public Text ftext;

	public GameObject note;

	public GameObject field;

	public AudioSource createSound;

	public void setGet () {
		ftext.text = reminder.text;
		note.SetActive (true);
		field.SetActive (false);
		createSound.Play ();
	}

}
