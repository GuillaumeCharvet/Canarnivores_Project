using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GangsterBehaviour : MonoBehaviour
{
    private Rigidbody rgbd;
    public int gang_appartenance;

    public bool isMoving = true;
    public bool isPausing = false;
    public bool isAttacking = false;
    public bool isAttacked = false;
    private float speed = 3.5f;
    private Vector3 currentDirection;
    private float currentCdMoving = 0f;
    private float maxCdMoving = 1f;
    private float currentCdPausing = 0f;
    private float maxCdPausing = 0.25f;
    private float currentCdAttacking = 0f;
    private float maxCdAttacking = 2.5f;
    private float radius = 2f;

    public Transform transformImage;
    public GameObject particuleCombat;

    public GangsterBehaviour currentEnnemi;
    public int currentEnnemiGang;

    public SelectionGang selectionGang;

    public bool entering = false, exiting = false;

    void Start()
    {
        selectionGang = FindObjectOfType<SelectionGang>();
        rgbd = transform.GetComponent<Rigidbody>();
        currentCdMoving = maxCdMoving + Random.Range(0f, 1f);
        currentCdPausing = maxCdPausing + Random.Range(0f, 0.25f);
        currentCdAttacking = maxCdAttacking;
    }
    void Update()
    {
        if (!isAttacking && !isAttacked)
        {
            var list = GameObject.FindGameObjectsWithTag("Gangster");
            foreach (var item in list)
            {
                if (Vector3.Distance(item.transform.position, transform.position) <= radius)
                {
                    currentEnnemi = item.GetComponent<GangsterBehaviour>();
                    currentEnnemiGang = currentEnnemi.gang_appartenance;
                    if (currentEnnemi.gang_appartenance != gang_appartenance)
                    {
                        isAttacking = true;
                        currentEnnemi.isAttacked = true;
                        currentEnnemi.isMoving = false;
                        currentEnnemi.isPausing = false;
                        Instantiate(particuleCombat, 0.5f * (transform.position + currentEnnemi.transform.position), Quaternion.identity);
                        isMoving = false;
                        isPausing = false;
                        Debug.Log("gangster trouvé de type " + currentEnnemi.gang_appartenance);
                    }
                }
            }
        }
        if (currentCdMoving <= 0f)
        {
            isMoving = false;
            isPausing = true;
            isAttacking = false;
            currentCdMoving = maxCdMoving + Random.Range(0f, 1f);
            var angle = Random.Range(0f, 360f);
            currentDirection = new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * speed;
        }
        if (currentCdPausing <= 0f)
        {
            isPausing = false;
            isMoving = true;
            isAttacking = false;
            currentCdPausing = maxCdPausing + Random.Range(0f, 0.25f);
        }
        if (currentCdAttacking <= 0f)
        {
            Debug.Log("" + gang_appartenance + "is attacking " + currentEnnemiGang);
            if (Random.Range(0f, 1f) > 0.5f)
            {
                Debug.Log("" + gang_appartenance + "is die to " + currentEnnemiGang);
                Destroy(transform.gameObject);
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 2)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale++;
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 3)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale++;*/
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 4)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale++;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 1)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 3)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale++;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 4)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale++;*/
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 1)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale--;*/
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 2)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale--;
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 4)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 1)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale--;
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 2)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale--;*/
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 3)
            {
                Debug.Log("AZI BOUGE");
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale++;
            }
            isAttacking = false;
            isMoving = true;
            currentCdAttacking = maxCdAttacking;
        }
        if (isAttacking || isAttacked)
        {
            currentCdAttacking -= Time.deltaTime;
        }
        if (isPausing)
        {
            currentCdPausing -= Time.deltaTime;
        }
        if (isMoving)
        {
            rgbd.velocity = currentDirection;
            currentCdMoving -= Time.deltaTime;
        }
        else
        {
            rgbd.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        var gangster = other.GetComponent<GangsterBehaviour>();
        if (gangster != null)
        {
            Debug.Log(gangster.gang_appartenance);
        }
    }
    public void StartCoroutineEntering()
    {
        StartCoroutine(StartEntering());
    }
    IEnumerator StartEntering()
    {
        while(transformImage.localScale.x > 0.4f && entering)
        {
            transformImage.localScale = 0.9f * transformImage.localScale;
            if (transformImage.localScale.x <= 0.4f) entering = false;
            yield return new WaitForFixedUpdate();
        }
    }
    public void StartCoroutineExiting()
    {
        StartCoroutine(StartExiting());
    }
    IEnumerator StartExiting()
    {
        while (transformImage.localScale.x < 1f && exiting)
        {
            transformImage.localScale = 1.06f * transformImage.localScale;
            if (transformImage.localScale.x >= 1f)
            {
                transformImage.localScale = new Vector3(1f, 1f, 1f);
                exiting = false;
            }
            yield return new WaitForFixedUpdate();
        }
    }
}
