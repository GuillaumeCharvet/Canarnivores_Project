using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GangManager : MonoBehaviour
{
    public int numberOfGangsters, numberOfGold;
    public Generation_Gangster generation_Gangster;
    public int gangNumber;
    [SerializeField, Range(-10, 10)]
    public int influenceVerticale = 0;
    [SerializeField, Range(-10, 10)]
    public int influenceHorizontale = 0;

    private int passiveIncome = 30;
    private float cdThunesMax = 3f;
    private float cdThunesCurrent;

    private float dx = 0.01f;

    public Transform trsfVertical, trsfHorizontal, trsfRepere;

    void Start()
    {
        cdThunesCurrent = cdThunesMax;
        numberOfGold = 130;
        numberOfGangsters = 0;
    }

    void Update()
    {
        cdThunesCurrent -= Time.deltaTime;
        if (cdThunesCurrent <= 0)
        {
            cdThunesCurrent = cdThunesMax;
            numberOfGold += passiveIncome;
        }
        UpdateZone();

        if (gangNumber == 1 && influenceVerticale >= 10 && influenceHorizontale >= 8)
        {

        }
    }
    public void UpdateZone()
    {
        if (gangNumber == 1)
        {
            if(trsfVertical.position.x > 10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x - dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x - dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            else if (trsfVertical.position.x < 10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x + dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x + dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            if (trsfHorizontal.position.z > 9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z - dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z - dx);
            }
            else if (trsfHorizontal.position.z < 9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z + dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z + dx);
            }
        }
        else if (gangNumber == 2)
        {
            if (trsfVertical.position.x > 10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x - dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x - dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            else if (trsfVertical.position.x < 10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x + dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x + dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            if (trsfHorizontal.position.z > -9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z - dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z - dx);
            }
            else if (trsfHorizontal.position.z < -9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z + dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z + dx);
            }
        }
        else if (gangNumber == 3)
        {
            if (trsfVertical.position.x > -10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x - dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x - dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            else if (trsfVertical.position.x < -10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x + dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x + dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            if (trsfHorizontal.position.z > -9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z - dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z - dx);
            }
            else if (trsfHorizontal.position.z < -9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z + dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z + dx);
            }
        }
        else if (gangNumber == 4)
        {
            if (trsfVertical.position.x > -10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x - dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x - dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            else if (trsfVertical.position.x < -10.5f + influenceHorizontale)
            {
                trsfVertical.position = new Vector3(trsfVertical.position.x + dx, trsfVertical.position.y, trsfVertical.position.z);
                trsfRepere.position = new Vector3(trsfRepere.position.x + dx, trsfRepere.position.y, trsfRepere.position.z);
            }
            if (trsfHorizontal.position.z > 9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z - dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z - dx);
            }
            else if (trsfHorizontal.position.z < 9.3f + influenceVerticale)
            {
                trsfHorizontal.position = new Vector3(trsfHorizontal.position.x, trsfHorizontal.position.y, trsfHorizontal.position.z + dx);
                trsfRepere.position = new Vector3(trsfRepere.position.x, trsfRepere.position.y, trsfRepere.position.z + dx);
            }
        }
    }
}
