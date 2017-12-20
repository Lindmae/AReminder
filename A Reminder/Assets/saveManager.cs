using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class saveManager : MonoBehaviour {
	public static saveManager Instance { set; get;}
	public SaveState state;

	private void Awake(){
		DontDestroyOnLoad (gameObject);
		Instance = this;
		Load ();

		Debug.Log (Helper.Serialize<SaveState> (state));
	}

	//save
	public void Save(){
		PlayerPrefs.SetString ("save", Helper.Serialize<SaveState>(state));
	}

	//load the previous save
	public void Load(){
		//do we already have a save?
		if(PlayerPrefs.HasKey("save")){
			state = Helper.Deseralize<SaveState> (PlayerPrefs.GetString ("save"));
		}
		else{
			state = new SaveState();
			Save ();
			Debug.Log("No save state found, creating new one");
		}
	}

	public void setActive1(bool newstate){
		state.active1 = newstate;
	}

	public bool isActive(){
		return state.active1;
	}





















}