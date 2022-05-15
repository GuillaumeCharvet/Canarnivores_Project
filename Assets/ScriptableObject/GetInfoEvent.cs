using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInfoEvent : MonoBehaviour
{
   
    public EventBulder Event;
    public InfoEvent _InfoEvent;


    [SerializeField]
    public int _Gang;

    [SerializeField]
    private Image _ImagePerso;
    [SerializeField]
    private Image _CadrePerso;
    [SerializeField]
    private Image _PointEvenement;
    [SerializeField]
    private Text _NomPerso;
    [SerializeField]
    private Text _Demande;

    [SerializeField]
    private int _NombreDeChoix;

    [SerializeField]
    private Text _Choix1;
    [SerializeField]
    public int _Choix1ValeurGang;
    [SerializeField]
    public int _Choix1NumDuGang;
    [SerializeField]
    public bool _Choix1BoolAction;


    [SerializeField]
    private Text _Choix2;
    [SerializeField]
    public int _Choi2ValeurGang;
    [SerializeField]
    public int _Choix2NumDuGang;
    [SerializeField]
    public bool _Choix2BoolAction;



    void Update()
    {
        InfoEvent.FindObjectOfType<InfoEvent>();


        _Gang = _InfoEvent.eventactif.Gang;
        _ImagePerso.sprite = _InfoEvent.eventactif.ImagePerso;
        _CadrePerso.sprite = _InfoEvent.eventactif.CadrePerso;
        //_PointEvenement.sprite = Event.PointEvenement;
        _NomPerso.text = _InfoEvent.eventactif.NomPerso;
        _Demande.text = _InfoEvent.eventactif.Demande;

        _Choix1.text = _InfoEvent.eventactif.Choix1;
        _Choix1ValeurGang = _InfoEvent.eventactif.Choix1ValeurGang;
        _Choix1NumDuGang = _InfoEvent.eventactif.Choix1NumDuGang;
        _Choix1BoolAction = _InfoEvent.eventactif.Choix1BoolAction;

        _Choix2.text = _InfoEvent.eventactif.Choix2;
        _Choi2ValeurGang = _InfoEvent.eventactif.Choix2ValeurGang;
        _Choix2NumDuGang = _InfoEvent.eventactif.Choix2NumDuGang;
        _Choix2BoolAction = _InfoEvent.eventactif.Choix2BoolAction;


    }
}
