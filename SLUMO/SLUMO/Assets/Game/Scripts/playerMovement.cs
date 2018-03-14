using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public GameObject star;
    Rigidbody rb;
    Vector3 movementSpeed;
    Vector3 Default = new Vector3(0, 0, 0);
    public int playerNum;
    bool lost;
    int myScore;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == star)
        {
            myScore++;
        }
    }
    // Update is called once per frame
    void Update () {

        if (!lost) //if I am still in the playing field
        {
            Vector3 movementSpeed = new Vector3(Input.GetAxisRaw("L_XAxis_" + playerNum), 0, -(Input.GetAxisRaw("L_YAxis_" + playerNum))); //movement speed is the XY values of analog stick state
            rb.velocity += movementSpeed / 1;

            float h = Input.GetAxis("L_XAxis_" + playerNum); //piece of the angle I need to face is X value from analog stick state
            float v = Input.GetAxis("L_YAxis_" + playerNum); //piece of the angle I need to face is Y value from analog stick state
            float angle = Mathf.Atan2(h, v) * Mathf.Rad2Deg; //the angle I need to face is this
            transform.localEulerAngles = new Vector3(0, -angle + 90, 0); //set facing direction to this angle
        }
        
    }
}
