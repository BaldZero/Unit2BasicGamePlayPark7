using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    public float speed = 20.0f;
    private float xRange = 15.0f;
    private float zRange = 15.0f;
    private float zzRange = 0.0f;
    private float verticalInput;

    public float livesNumber = 3.0f;
    public float livesSubtract = 1f;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives: 3");
        Debug.Log("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        //limits how much the player can move horizontally
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.z < zzRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zzRange);
        }
        if(transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *  verticalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch steak at the animals when the player presses space
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        
    }
    //private void OnTriggerEnter(Collider other)
}
    
