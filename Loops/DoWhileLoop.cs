using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

void Start()
{
	bool shotMade = true;

	do {
		print ("You Missed!");
	} while(shotMade == true);
}
}
