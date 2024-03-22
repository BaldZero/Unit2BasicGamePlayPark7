using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30f;
    private float lowerBound = -10f;
    private float xBound = 20f;
    private float xxBound = -20f;
    private CheatCode gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("CheatCode").GetComponent<CheatCode>();
    }

    // Update is called once per frame
    void Update()
    {
        //destroys gameobjects based on z position
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            
        }
        else if (transform.position.z < lowerBound)
        {
            //Destroys animals and tells the player game over
            Destroy(gameObject);
            gameManager.AddLive(-1);
        }
        else if(transform.position.x > xBound )
        {
            Destroy (gameObject);
            gameManager.AddLive(-1);
        }
        else if ((transform.position.x < xxBound))
        {
            Destroy (gameObject);
            gameManager.AddLive(-1);
        }
    }
}
