using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSound : MonoBehaviour {

    public AudioSource slime;
    
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        slime.mute = false;
    }

    // Update is called once per frame
    void Update () {
		
        

	}
}
