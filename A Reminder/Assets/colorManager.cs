using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class colorManager : MonoBehaviour {

	public Dropdown list;
	private GameObject[] notes;

	private int listValue;

	void Start(){
		if (notes == null) {
			notes = GameObject.FindGameObjectsWithTag ("Header");
		}

	}

	public void changeColor(){
		listValue = list.value;

		notes = GameObject.FindGameObjectsWithTag ("Header");

		Debug.Log ("Found headers: " + notes.Length);
		foreach (GameObject note in notes)
		{
			//red
			if(list.value == 0){
				Debug.Log("value is 0");
				note.GetComponent<Renderer> ().material.color = Color.red;
			}
			//orange
			else if(list.value == 1){
				Debug.Log("value is 1");
				note.GetComponent<Renderer>().material.color = Color.white;
			}
			//yellow
			else if(list.value == 2){
				Debug.Log("value is 2");
				note.GetComponent<Renderer>().material.color = Color.yellow;
			}
			//green
			else if(list.value == 3){
				Debug.Log("value is 3");
				note.GetComponent<Renderer> ().material.color = Color.green;
			}
			//blue
			else if(list.value == 4){
				Debug.Log("value is 4");
				note.GetComponent<Renderer> ().material.color = Color.blue;
			}
			//purple
			else{
				Debug.Log("value is 5");
				//note.GetComponent<Renderer>().material.color = new Color (color.r,color.g,color.b,color.a);
				note.GetComponent<Renderer>().material.color = Color.magenta;
			}

		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
