using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class tab : MonoBehaviour


{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
			Debug.Log("Space key was pressed.");

		if (Input.GetKeyUp(KeyCode.Tab))
			Debug.Log("Space key was released.");
	}
}