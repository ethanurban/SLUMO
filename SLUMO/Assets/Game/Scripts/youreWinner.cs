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

    //music
    public GameObject winMusic;
    public AudioSource gameMusic;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (p1.transform.position.y < 600)
        {
            if (p2.transform.position.y < 600)
            {
                if (p3.transform.position.y < 600)
                {
                    //PLAYER 4 WINS
                    Debug.Log("player 4 wins");
                    wintext4.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    gameMusic.volume = 0;

                }

                else if (p4.transform.position.y < 600)

                {
                    //PLAYER 3 WINS
                    Debug.Log("player 3 wins");
                    wintext3.gameObject.SetActive(true);

                    //win music
                    winMusic.gameObject.SetActive(true);

                    gameMusic.volume = 0;
                }
            }

            else if (p3.transform.position.y < 600 && p4.transform.position.y < 600)
            {
                //PLAYER 2 WINS
                Debug.Log("player 2 wins");
                wintext2.gameObject.SetActive(true);

                //win music
                winMusic.gameObject.SetActive(true);

                gameMusic.volume = 0;
            }

        }

        else if (p3.transform.position.y < 600 && p4.transform.position.y < 600 && p2.transform.position.y < 600)
            
        {
            //PLAYER 1 WINS
            Debug.Log("player 1 wins");
            wintext1.gameObject.SetActive(true);


            //win music
            winMusic.gameObject.SetActive(true);

            gameMusic.volume = 0;
        }
    }
}
