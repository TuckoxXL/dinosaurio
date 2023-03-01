using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scorenumero;
    public float scorSuma;

    private void Start()
    {
        scorenumero = 0f;
        scorSuma = 10f;
    }


    private void Update()
    {
        scoreText.text = "Score:" + (int)scorenumero;
        scorenumero += scorSuma * Time.deltaTime;
    }
}
