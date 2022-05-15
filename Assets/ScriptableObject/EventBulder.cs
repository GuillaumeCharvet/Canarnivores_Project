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
    public int Choix1ValeurGang2;
    public int Choix1NumDuGang2;
    public int Choix1ValeurArgent;
    public bool Choix1BoolAction;
    
    public string Choix2;
    public int Choix2ValeurGang;
    public int Choix2NumDuGang;
    public int Choix2ValeurGang2;
    public int Choix2NumDuGang2;
    public int Choix2ValeurArgent;
    public bool Choix2BoolAction;
  
    public int VarAle;
}