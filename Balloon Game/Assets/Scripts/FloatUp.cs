using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatUp : MonoBehaviour
{

    public float moveSpeed; // speed ballon floats up at
    public float upperBound; // top boundary for when the balloon exits the screen it will get destroyed

    private Balloon balloon; // refrence the ballon gameobject
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        balloon = GetComponent<Balloon>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // move balloon upwards
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        // Destroy ballon if it passes the tip boundary
        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
