using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoEvent : MonoBehaviour
{
    public List<EventBulder> Event;
    public EventBulder eventactif;

    public GameObject PointEvent;
    private int VarAle;

    public Transform TransformGangster;
    public GangsterBehaviour GangAttach;

    //ici le scrip qui declache les event parmit la liste
    public void AddEventAlea()
    {

        VarAle =(Random.Range(0, Event.Count));
        eventactif = Event[VarAle];
        eventactif.VarAle = VarAle;

        eventlaucher();

    }

    private Transform TransformGangstere;

    private GameObject listeGangster;

    public void eventlaucher()
    {

        if(eventactif.Gang == 1)
        {
            var listeGangster = GameObject.FindGameObjectsWithTag("Gangster");
            var listeGangsterID = new List<GameObject>();
            for (int i = 0; i < listeGangster.Length; i++)
            {
                if (listeGangster[i].GetComponent<GangsterBehaviour>().gang_appartenance == 1)
                {
                    listeGangsterID.Add(listeGangster[i]);
                }
            }
            var gangsterAlea = (Random.Range(0, listeGangsterID.Count));
            PointEvent.transform.position = listeGangsterID[gangsterAlea].transform.position;
            
        }
        else if (eventactif.Gang == 2)
        {
            var listeGangster = GameObject.FindGameObjectsWithTag("Gangster");
            var listeGangsterID = new List<GameObject>();
            for (int i = 0; i < listeGangster.Length; i++)
            {
                if (listeGangster[i].GetComponent<GangsterBehaviour>().gang_appartenance == 2)
                {
                    listeGangsterID.Add(listeGangster[i]);
                }
            }
            var gangsterAlea = (Random.Range(0, listeGangsterID.Count));
            PointEvent.transform.position = listeGangsterID[gangsterAlea].transform.position;
        }
        else if (eventactif.Gang == 3)
        {
            var listeGangster = GameObject.FindGameObjectsWithTag("Gangster");
            var listeGangsterID = new List<GameObject>();
            for (int i = 0; i < listeGangster.Length; i++)
            {
                if (listeGangster[i].GetComponent<GangsterBehaviour>().gang_appartenance == 3)
                {
                    listeGangsterID.Add(listeGangster[i]);
                }
            }
            var gangsterAlea = (Random.Range(0, listeGangsterID.Count));
            PointEvent.transform.position = listeGangsterID[gangsterAlea].transform.position;
        }
        else if (eventactif.Gang == 4)
        {
            var listeGangster = GameObject.FindGameObjectsWithTag("Gangster");
            var listeGangsterID = new List<GameObject>();
            for (int i = 0; i < listeGangster.Length; i++)
            {
                if (listeGangster[i].GetComponent<GangsterBehaviour>().gang_appartenance == 4)
                {
                    listeGangsterID.Add(listeGangster[i]);
                }
            }
            var gangsterAlea = (Random.Range(0, listeGangsterID.Count));
            PointEvent.transform.position = listeGangsterID[gangsterAlea].transform.position;
        }
        else if (eventactif.Gang == 5)
        {
            /*var listeGangster = GameObject.FindGameObjectsWithTag("Gangster");
            var gangsterAlea = (Random.Range(0, listeGangster.Length));
            PointEvent.transform.position = listeGangster[gangsterAlea].transform.position;*/
            PointEvent.GetComponent<SpriteRenderer>().sprite = eventactif.PointEvenement;
        }

        
        PointEvent.SetActive(true);

    }
}
