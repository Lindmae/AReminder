using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class changeName : MonoBehaviour {

	public InputField namee;

	private GameObject[] notes;

	// Use this for initialization
	void Start () {
		loadInformation.loadAllInformation ();
		namee.text = GameInformation.name;
		updateName ();
		saveInformation.saveAllInformation ();
		
	}

	public void updateName(){
		notes = GameObject.FindGameObjectsWithTag ("Name");

		Debug.Log ("Found name: " + notes.Length);


		foreach (GameObject note in notes) {
			if (namee.text.Length == 0) {
			} else {
				note.GetComponent<UnityEngine.UI.Text> ().text = namee.text;
			}

		}

		GameInformation.name = namee.text;

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
