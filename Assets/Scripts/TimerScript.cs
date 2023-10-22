using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float currentTime;

    void FixedUpdate()
    {
        currentTime = currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("Timer: 00");
    }
}
