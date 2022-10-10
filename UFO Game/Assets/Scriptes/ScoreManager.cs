using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; //keep our score value
    public TextMeshProUGUI scoreText; // refrence visual text ui element to change


    // Start is called before the first frame update
    void Start()
    {
    
    }
    
    // this function rewards the player
    public void IncreaseScore(int amount)
    {
        score += amount; //add amount to the score
        UpdateScoreText(); // Update the score ui text
    }
    // this function penalizes the player
    public void DecreaseScore(int amount)
    {
        score -= amount; //subtract amount to the score
        UpdateScoreText(); // Update the score ui text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
