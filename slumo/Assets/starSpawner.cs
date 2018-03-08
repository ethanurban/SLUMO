using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSpawner : MonoBehaviour {

    public GameObject star;
    
    bool inRange;
    bool Reset;
	// Use this for initialization
	void Start () {
        Reset = star.GetComponent<starScript>().timeToReset; //read variable from child object
	}
    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject == star) //if your child is in game limits
        {
            inRange = true;
        }
    }
    // Update is called once per frame
    void Update () {
		if (!inRange) //if child is not in designated limits
        {
            Reset = true; //time to choose new random location
        }
        if (Reset) // if the location is not valid or if the child script says we need to move
        {
            star.transform.position = new Vector3(1, 1, 1); //TODO make coordinates random within limits of playing field
            Reset = false; //don't repeat respawn unless needed again
        }
        
	}
}
