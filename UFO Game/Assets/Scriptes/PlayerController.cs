using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hInput;
    public float speed;

    public float xRange = 17.0f;

    public GameObject lazerBolt;
    public Transform blaster;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set horizontal input to recieve values from the keyboard keymap horizontal
        hInput = Input.GetAxis("Horizontal");

        //Move player left and right
        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);

        //Keep player within set bounds
        //keep player inside right wall at set xRange
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // keep player inside left wall at set -xRange
         if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation); //
        }
    }
}
