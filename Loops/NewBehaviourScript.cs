using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

int reLoad = 6;

void Start ()
{
	for(int i = 0; i < reLoad; i++)
	{
		Debug.Log("Gathering more ammo: " + i);
	}
}
}
