using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPouvoirs : MonoBehaviour
{
    private bool isUsingPower1 = false, isUsingPower2 = false, isUsingPower3 = false, isUsingPower4 = false;
    public int layerMask = 7;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isUsingPower1)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask))
                {
                    //Debug.Log(hit.transform.name);
                    //Debug.Log("hit");
                    int xGrid = (int)hit.transform.position.x;
                    int yGrid = (int)hit.transform.position.z;
                }
            }
            else if(isUsingPower2)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask))
                {
                    //Debug.Log(hit.transform.name);
                    //Debug.Log("hit");
                    int xGrid = (int)hit.transform.position.x;
                    int yGrid = (int)hit.transform.position.z;
                }
            }
            else if(isUsingPower3)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask))
                {
                    //Debug.Log(hit.transform.name);
                    //Debug.Log("hit");
                    int xGrid = (int)hit.transform.position.x;
                    int yGrid = (int)hit.transform.position.z;
                }
            }
            else if (isUsingPower4)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 1000, layerMask))
                {
                    //Debug.Log(hit.transform.name);
                    //Debug.Log("hit");
                    int xGrid = (int)hit.transform.position.x;
                    int yGrid = (int)hit.transform.position.z;
                }
            }
        }
    }
}
