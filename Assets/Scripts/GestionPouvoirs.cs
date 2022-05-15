using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    public bool isUsingPower1 = false, isUsingPower2 = false, isUsingPower3 = false, isUsingPower4 = false;
    public int layerMask = 1 << 14;
    public LayerMask layerMask2;

    public GameObject zonePolice;
    public GameObject zoneTravaux;
    public GameObject zoneFestoche;

    public AudioSource audioPolice;

    public ThunePlayer thunePlayer;
    public int goldPlayer;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("****** CA CLIQUE ******");
            if (isUsingPower1 && thunePlayer.playerGold >= 30)
            {
                thunePlayer.playerGold -= 30;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    UsePower1(hit.point);
                }
            }
            else if(isUsingPower2 && thunePlayer.playerGold >= 50)
            {
                thunePlayer.playerGold -= 50;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    UsePower2(hit.point);
                }
            }
            else if(isUsingPower3 && thunePlayer.playerGold >= 90)
            {
                thunePlayer.playerGold -= 90;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    UsePower3(hit.point);
                }
            }
            else if (isUsingPower4)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    var xpos = hit.transform.position.x;
                    var ypos = hit.transform.position.z;
                    Debug.Log("xpos : " + xpos + " ypos : " + ypos);
                }
            }
        }
    }

    public void UsePower1(Vector3 position)
    {
        Instantiate(zonePolice, position, Quaternion.identity);
        audioPolice.volume = 0.6f;
        audioPolice.Play();
    }
    public void UsePower2(Vector3 position)
    {
        Instantiate(zoneTravaux, position, Quaternion.identity);
    }
    public void UsePower3(Vector3 position)
    {
        Instantiate(zoneFestoche, position, Quaternion.identity);
    }

    public void CanClickButton1()
    {
        Debug.Log("BOUTON1");
        if (isUsingPower1)
        {
            isUsingPower1 = false;
        }
        else
        {
            isUsingPower1 = true;
            isUsingPower2 = false;
            isUsingPower3 = false;
        }
    }
    public void CanClickButton2()
    {
        Debug.Log("BOUTON2");
        if (isUsingPower2)
        {
            isUsingPower2 = false;
        }
        else
        {
            isUsingPower1 = false;
            isUsingPower2 = true;
            isUsingPower3 = false;
        }
    }
    public void CanClickButton3()
    {
        Debug.Log("BOUTON3");
        if (isUsingPower3)
        {
            isUsingPower3 = false;
        }
        else
        {
            isUsingPower1 = false;
            isUsingPower2 = false;
            isUsingPower3 = true;
        }
    }
}
