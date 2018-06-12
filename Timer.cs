using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimerText;
    private float startTime;
    private bool finished = false;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - startTime;

        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f0");

        TimerText.text = min + ":" + sec;
	}

    public void finnished()
    {
        finished = true;
        TimerText.color = Color.yellow;
    }
}
