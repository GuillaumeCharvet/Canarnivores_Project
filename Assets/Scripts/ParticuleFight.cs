using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticuleFight : MonoBehaviour
{
    private float spawnLenght = 0.5f;
    private bool isSpawning = true;
    private float stayLenght = 1f;
    private bool isDespawning = false;
    private float stayDespawn = 1f;
    private bool needToDie = false;

    private SpriteRenderer sprite;

    private void Start()
    {
        transform.position = transform.position + Vector3.up;
        transform.Rotate(40f, 0f, 0f);
        sprite = transform.GetComponent<SpriteRenderer>();
        sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, 0f);
    }

    void Update()
    {
        if (isSpawning)
        {
            spawnLenght -= Time.deltaTime;
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, Mathf.Min(1f, sprite.color.a + Time.deltaTime / 0.5f));
        }
        if (spawnLenght <= 0f) isSpawning = false;
        if (!isSpawning && !isDespawning) stayLenght -= Time.deltaTime;
        if (stayLenght <= 0f) isDespawning = true;
        if (isDespawning)
        {
            stayDespawn -= Time.deltaTime;
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a - Time.deltaTime / 1f);
        }
        if (stayDespawn <= 0f) needToDie = true;
        if (needToDie) Destroy(transform.gameObject);
    }
}
