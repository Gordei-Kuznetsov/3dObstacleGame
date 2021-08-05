using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour
{
    float currentTime = 0f;
    bool timerRunning = true;
    public Text scoreText;
    public Text finishText;

    private void Update() {
        if(timerRunning) {
            currentTime += 100 * Time.deltaTime;
            scoreText.text = currentTime.ToString("F");
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player") {
            timerRunning = false;
            finishText.text = "YOU LOST";
        }
    }
}
