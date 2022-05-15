using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public InfoEvent _InfoEvent;

    float time;
    public float TimerInterval = 5f ;
    float tick;

    private void Awake()
    {
        InfoEvent.FindObjectOfType<InfoEvent>();
        time = (int)Time.time ;
        tick = TimerInterval ;
    }

    public void Update()
    {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}", 4 - Mathf.Floor(time/60), 59 - time%60) ;
        //time.ToString()

        time = (int)Time.time ;

        if(time == tick)
        {
            tick=time+TimerInterval ;
            //Executer le code du timer 
            TimerExecute(); 
        }

        if(time < 0)
        {
            time = 0;
        }
    }

    void TimerExecute()
    {
        Debug.Log("Timmer");
        _InfoEvent.AddEventAlea();
    }

}