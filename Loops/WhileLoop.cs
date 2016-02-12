using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	// Use this for initialization
int fireworksShot = 8;


void Start ()
{
	while(fireworksShot > 0)
	{
		Debug.Log ("Kaboom!");
		fireworksShot--;
	}
}
}
