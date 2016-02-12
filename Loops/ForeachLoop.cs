using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour {

	// Use this for initialization
void Start ()
{
	string[] strings = new string[5];

	strings[0] = "Punch";
	strings[1] = "Kick";
	strings[2] = "Dodge";
	strings[3] = "Counter";
	strings[4] = "Elbow";

	foreach(string item in strings)
	{
		print (item);
	}
}
}