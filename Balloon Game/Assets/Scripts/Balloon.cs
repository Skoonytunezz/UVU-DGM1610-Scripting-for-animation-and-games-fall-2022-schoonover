using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{

    public int clickToPop = 3; // how many clicks till balloon pops
    public float scaleToInrease = 0.10f; // amount ballon inflates with each click
    public int scoreToGive = 100;
    private ScoreManager scoreManager;



    // Start is called before the first frame update
    void Start()
    {
        //Refrence ScoreManger component 
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        clickToPop -= 1; // reduce clicks by one

        //Inflate Balloon set amount upon clicks
        transform.localScale += Vector3.one * scaleToInrease;

        // Check to see of clickToPop has reached zero. If it has then pop balloon
        if(clickToPop == 0)
        {
            // send points to score manager and update the score
            scoreManager.IncreaseScoreText(scoreToGive);
            // destroy this balloon
            Destroy(gameObject);
        }
    }
}
