using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour 
{
	
	float cubeSpeed = 75.0f;
	float fastCubeSpeed = 60.0f;
	float slowCubeSpeed = 35.0f;

	void update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			SpeedTest();

		cubeSpeed -= Time.deltaTime * 5f;
	}

	void SpeedTest ()
	{
		if(cubeSpeed > fastCubeSpeed) 
		{
			print("Slow down!");
		} 
		else if(cubeSpeed < slowCubeSpeed) 
		{
			print("Speed it up!");
		} 
		else
		{
			print("Good pace.");
		}
	}
}