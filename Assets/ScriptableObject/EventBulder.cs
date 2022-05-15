using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventBuilder", menuName = "EventBuilder", order = 0)]
public class EventBulder : ScriptableObject
{
    public int Gang;
    public AudioClip SonDuGang;
    public Sprite ImagePerso;
    public Sprite CadrePerso;
    public Sprite PointEvenement;
    public string NomPerso;
    [TextArea(10, 25)]
    public string Demande;
    
    public string Choix1;
    public int Choix1ValeurGang;
    public int Choix1NumDuGang;
    public bool Choix1BoolAction;
    
    public string Choix2;
    public int Choix2ValeurGang;
    public int Choix2NumDuGang;
    public bool Choix2BoolAction;

}