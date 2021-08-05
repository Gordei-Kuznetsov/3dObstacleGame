using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    float currentTime = 0f;
    public Text scoreText;

    private void Update()
    {
        currentTime += 10 * Time.deltaTime;
        scoreText.text = currentTime.ToString("0");
    }

}
