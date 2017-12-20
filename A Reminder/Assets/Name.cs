using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : IPersistence {

	public string name;
	public const string NameOfFile = "name.dat";

	public string FileName{
		get{ 
			return NameOfFile;
		}
	}

}
