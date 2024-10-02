using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public float scoreValue = 0f;
    public float highScoreValue;
    public float pointIncreasedPerSecond = 1f;
    public bool scoreIncreasing;

    // Start is called before the first frame update

    void Start()
    {
        if (PlayerPrefs.GetFloat("HighScore") != null)
        {
            highScoreValue = PlayerPrefs.GetFloat("HighScore");
        }
    }
    void FixedUpdate()
    {
        scoreText.text = "SCORE: " + Mathf.Round(scoreValue);
        highScoreText.text = "HIGH SCORE: " + Mathf.Round(highScoreValue);

        if (scoreIncreasing)
        {
            scoreValue += pointIncreasedPerSecond * Time.fixedDeltaTime;
        }

        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetFloat("HighScore", highScoreValue);
        }
    }
}
