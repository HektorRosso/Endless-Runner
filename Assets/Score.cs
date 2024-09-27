using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int scoreValue;
    public int time;

    // Start is called before the first frame update
    void Update()
    {
        Invoke("ScoreCount", time);
    }

    void ScoreCount()
    {
        scoreValue = scoreValue + 1;
        scoreText.text = "SCORE: 0" + scoreValue;
    }
}
