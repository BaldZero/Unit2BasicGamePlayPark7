using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float coolSpawn = 2.0f;
    // Update is called once per frame
    void Update()
    {
        coolSpawn = coolSpawn - Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (coolSpawn <= 1)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                coolSpawn = 2;
            }
            else if (coolSpawn <= 2) 
            {
                Debug.Log("Spam isn't cool Fam");
                return;
            }
        }
    } 
}
