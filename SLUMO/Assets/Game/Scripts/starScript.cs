using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starScript : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public bool timeToReset;
	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player1 || player2 || player3 || player4) //if I collide with one of the players
        {
            timeToReset = true; //I need to move
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
