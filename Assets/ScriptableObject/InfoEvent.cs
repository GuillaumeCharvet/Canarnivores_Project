using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoEvent : MonoBehaviour
{
    public List<EventBulder> Event;
    public EventBulder Eventtest;
    public EventBulder eventactif;

    public GameObject PointEvent;
    private int VarAle;

    //ici le scrip qui declache les event parmit la liste

    public void AddEventAlea()
    {

        VarAle =(Random.Range(0, Event.Count));
        eventactif = Event[VarAle];
        Debug.Log(VarAle);
        PointEvent.SetActive(true);
    }


    public void Update()
    {
        //eventactif = Event[0];
    }

}
