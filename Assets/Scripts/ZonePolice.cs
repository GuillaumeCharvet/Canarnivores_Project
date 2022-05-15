using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonePolice : MonoBehaviour
{
    private float spawnLenght = 0.5f;
    private bool isSpawning = true;
    private float stayLenght = 4f;
    private bool isDespawning = false;
    private float stayDespawn = 1f;
    private bool needToDie = false;

    public Material material;

    void Start()
    {
        material.color = new Color(0.2f, 0.2f, 0.2f, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gangster")
        {
            other.GetComponent<GangsterBehaviour>().isFleeing = true;
        }
    }

    void Update()
    {
        if (isSpawning)
        {
            spawnLenght -= Time.deltaTime;
            material.color = new Color(material.color.r, material.color.g, material.color.b, Mathf.Min(1f, material.color.a + Time.deltaTime / 0.5f)); //
        }
        if (spawnLenght <= 0f) isSpawning = false;
        if (!isSpawning && !isDespawning) stayLenght -= Time.deltaTime;
        if (stayLenght <= 0f) isDespawning = true;
        if (isDespawning)
        {
            stayDespawn -= Time.deltaTime;
            material.color = new Color(material.color.r, material.color.g, material.color.b, Mathf.Min(1f, material.color.a + Time.deltaTime / 4f));
        }
        if (stayDespawn <= 0f) needToDie = true;
        if (needToDie) Destroy(transform.gameObject);
    }
}
