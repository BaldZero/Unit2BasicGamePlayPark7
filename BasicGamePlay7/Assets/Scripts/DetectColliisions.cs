using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectColliisions : MonoBehaviour
{


    private CheatCode gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("CheatCode").GetComponent<CheatCode>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AddLive(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            gameManager.AddScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
