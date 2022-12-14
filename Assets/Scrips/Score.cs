using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text HiScoreText;
    int score;
    Text scoreText;

    float Timer;
    float maxTimer;

    // Start is called before the first frame update
    void Start()
    {
        HiScoreText.text = "Puntaje Maximo " + PlayerPrefs.GetInt("highscore", 0).ToString("000000");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTimer = 0.1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= maxTimer)
        {
            score++;
            string v = score.ToString("000000");
            scoreText.text = v;
            Timer = 0;
        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                HiScoreText.text = "Puntaje Maximo " + PlayerPrefs.GetInt("highscore", 0).ToString("000000");
            }
        }
    }
    
}
