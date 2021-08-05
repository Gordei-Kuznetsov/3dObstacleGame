using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHandler : MonoBehaviour
{
    public GameObject finish;

    // Start is called before the first frame update
    void Start()
    {
        finish.GetComponent<TimerHandler>().enabled = false;
    }

    private void OnTriggerEnter() {
        finish.GetComponent<TimerHandler>().enabled = true;
    }
}
