using System.Collections;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class persistenceManager : MonoBehaviour {

	public static persistenceManager instance;

	void Awake(){
		Environment.SetEnvironmentVariable ("MONO_REFLECTION_SERIALIZER", "yes");
		instance = this;
	}

	public void Save(IPersistence objectToSave){
		BinaryFormatter formatter = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/" + objectToSave.FileName, FileMode.OpenOrCreate);
		formatter.Serialize (file, objectToSave);
		file.Close ();
	}

	public System.Object Load(string nameOfFile){
		var serializedObject = new System.Object ();
		if(File.Exists(Application.persistentDataPath + "/" + nameOfFile)){
			BinaryFormatter formatter = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/" + nameOfFile, FileMode.Open);
			serializedObject = formatter.Deserialize (file);
			file.Close ();
		}
		return serializedObject;
	}

}
