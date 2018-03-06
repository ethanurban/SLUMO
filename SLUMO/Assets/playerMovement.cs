using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    Vector3 movementSpeed;
    Vector3 Default = new Vector3(0, 0, 0);
    double Direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movementSpeed = new Vector3(Input.GetAxisRaw("L_XAxis_1"), 0, -(Input.GetAxisRaw("L_YAxis_1")));
        transform.position += movementSpeed / 48;

        float h = Input.GetAxis("L_XAxis_1");
        float v = Input.GetAxis("L_YAxis_1");
        float angle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
        transform.localEulerAngles = new Vector3(0, -angle, 0);
	}
}
