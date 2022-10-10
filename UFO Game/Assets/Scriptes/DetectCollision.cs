using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private ScoreManager scoreManager;
    public int scoreToGive;


    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); //increase score amount to ScoreToGive
        Destroy(other.gameObject); //Destroy this game object
        Destroy(gameObject);
    }
}
