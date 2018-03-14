using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youreWinner : MonoBehaviour {

    //PLAYERS
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    //UI ELEMENTS
    public GameObject wintext1;
    public GameObject wintext2;
    public GameObject wintext3;
    public GameObject wintext4;

    //player out elements
    public GameObject p1out;
    public GameObject p2out;
    public GameObject p3out;
    public GameObject p4out;

    //music
    public GameObject winMusic;
    public AudioSource gameMusic;

    //Exit Button
    public GameObject EXIT;






    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (p1.transform.position.y < 626)
        {
            if (p2.transform.position.y < 626)
            {
                if (p3.transform.position.y < 626)
                {
                    //PLAYER 4 WINS
                    Debug.Log("player 4 wins");
                    wintext4.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    //mute music
                    gameMusic.mute = true;

                    EXIT.gameObject.SetActive(true);

                }

                else if (p4.transform.position.y < 626)

                {
                    //PLAYER 3 WINS
                    Debug.Log("player 3 wins");
                    wintext3.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    //mute music
                    gameMusic.mute = true;

                    EXIT.gameObject.SetActive(true);
                }
            }

            else if (p3.transform.position.y < 626 && p4.transform.position.y < 626)
            {
                //PLAYER 2 WINS
                Debug.Log("player 2 wins");
                wintext2.gameObject.SetActive(true);

                //win music
                winMusic.gameObject.SetActive(true);

                //mute music
                gameMusic.mute = true;

                EXIT.gameObject.SetActive(true);
            }

        }

        else if (p3.transform.position.y < 626 && p4.transform.position.y < 628 && p2.transform.position.y < 626)

        {
            //PLAYER 1 WINS
            Debug.Log("player 1 wins");
            wintext1.gameObject.SetActive(true);


            //win music
            winMusic.gameObject.SetActive(true);

            //mute music
            gameMusic.mute = true;

            EXIT.gameObject.SetActive(true);
        }







        //PLAYER IS OUT functions

        //player one out!
        if (p1.transform.position.y < 628)
        {
            p1out.gameObject.SetActive(true);
        }

        //player two out!
        if (p2.transform.position.y < 628)
        {
            p2out.gameObject.SetActive(true);
        }

        //player three out!
        if (p3.transform.position.y < 628)
        {
            p3out.gameObject.SetActive(true);
        }

        //player four out!
        if (p4.transform.position.y < 628)
        {
            p4out.gameObject.SetActive(true);
        }
    }
}
