using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime=0;
    [SerializeField] float duration=0;
    [SerializeField] Image bar;
    [SerializeField] DeliverySystem delivery;

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            
            bar.fillAmount = Mathf.InverseLerp(0, duration, remainingTime);
        }
        else if(remainingTime < 0)
        {
            remainingTime = 0;
            delivery.DeliveryFailed();
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void StartTimer(float dur)
    {
        duration = dur;
        remainingTime = duration;
    }

}
