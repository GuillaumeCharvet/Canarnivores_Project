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
    public AudioClip _SonDuGang;

    [SerializeField]
    private Image _ImagePerso;
    [SerializeField]
    private Image _CadrePerso;
    [SerializeField]
    private SpriteRenderer _PointEvenement;
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
    public int _Choix1ValeurGang2;
    [SerializeField]
    public int _Choix1NumDuGang2;
    [SerializeField]
    public int _Choix1ValeurArgent;


    [SerializeField]
    public bool _Choix1BoolAction;


    [SerializeField]
    private Text _Choix2;
    [SerializeField]
    public int _Choi2ValeurGang;
    [SerializeField]
    public int _Choix2NumDuGang;
    [SerializeField]
    public int _Choix2ValeurGang2;
    [SerializeField]
    public int _Choix2NumDuGang2;
    [SerializeField]
    public int _Choix2ValeurArgent;
    [SerializeField]
    public bool _Choix2BoolAction;
    
    
    [SerializeField]
    public int _varAle;




    void Update()
    {
        InfoEvent.FindObjectOfType<InfoEvent>();


        _Gang = _InfoEvent.eventactif.Gang;

        _SonDuGang = _InfoEvent.eventactif.SonDuGang;

        _ImagePerso.sprite = _InfoEvent.eventactif.ImagePerso;
        _CadrePerso.sprite = _InfoEvent.eventactif.CadrePerso;
        
        _NomPerso.text = _InfoEvent.eventactif.NomPerso;
        _Demande.text = _InfoEvent.eventactif.Demande;

        _Choix1.text = _InfoEvent.eventactif.Choix1;
        _Choix1ValeurGang = _InfoEvent.eventactif.Choix1ValeurGang;
        _Choix1NumDuGang = _InfoEvent.eventactif.Choix1NumDuGang;
        _Choix1ValeurGang2 = _InfoEvent.eventactif.Choix1ValeurGang2;
        _Choix1NumDuGang2 = _InfoEvent.eventactif.Choix1NumDuGang2;
        _Choix1ValeurArgent = _InfoEvent.eventactif.Choix1ValeurArgent;
        _Choix1BoolAction = _InfoEvent.eventactif.Choix1BoolAction;

        _Choix2.text = _InfoEvent.eventactif.Choix2;
        _Choi2ValeurGang = _InfoEvent.eventactif.Choix2ValeurGang;
        _Choix2NumDuGang = _InfoEvent.eventactif.Choix2NumDuGang;
        _Choix2ValeurGang2 = _InfoEvent.eventactif.Choix2ValeurGang2;
        _Choix2NumDuGang2 = _InfoEvent.eventactif.Choix1NumDuGang2;
        _Choix2ValeurArgent = _InfoEvent.eventactif.Choix2ValeurArgent;
        _Choix2BoolAction = _InfoEvent.eventactif.Choix2BoolAction;

        _varAle = _InfoEvent.eventactif.VarAle;

    }
}
