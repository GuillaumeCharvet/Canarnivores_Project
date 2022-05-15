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

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("****** CA CLIQUE ******");
            if (isUsingPower1)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    UsePower1(hit.point);
                }
            }
            else if(isUsingPower2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask2))
                {
                    UsePower2(hit.point);
                }
            }
            else if(isUsingPower3)
            {
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
}
