using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    // Made up variables for practice

    int time = 100
    int y = 50
    int x = 90
    

    string cloudCover = "Strom Clouds"
    string lightColor = "Green"



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // my five conditions
        if(time > 99)
        {
            Destroy(gameObject);
        }
        
        if(time == y)
        {
            Console.WriteLine("Half Way there");
        }

        if(cloudCover == "Storm Clouds")
        {
            Console.WriteLine("Better stay inside");
        }

        if(time >= x)
        {
            Console.WriteLine("10 more seconds")
        }

        if(lightColor == Green)
        {
            Consol.WriteLine("GO!!")
        }
    }
}
