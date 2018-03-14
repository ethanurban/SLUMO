using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        Application.Quit();

        Debug.Log("You Quit the Game!");
	}
}
