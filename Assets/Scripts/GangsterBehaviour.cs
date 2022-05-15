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
    public bool isFleeing = false;
    private float speed = 3.5f;
    private Vector3 currentDirection;
    private float currentCdMoving = 0f;
    private float maxCdMoving = 1f;
    private float currentCdPausing = 0f;
    private float maxCdPausing = 0.25f;
    private float currentCdAttacking = 0f;
    private float maxCdAttacking = 2.5f;
    private float currentCdFleeing = 0f;
    private float maxCdFleeing = 3f;
    private float radius = 2f;

    public Transform transformImage;
    public GameObject particuleCombat;

    public GangsterBehaviour currentEnnemi;
    public int currentEnnemiGang;

    public SelectionGang selectionGang;

    public bool entering = false, exiting = false;

    public GangManager gang1, gang2, gang3, gang4;
    public Generation_Gangster gangGene1, gangGene2, gangGene3, gangGene4;

    void Start()
    {
        selectionGang = FindObjectOfType<SelectionGang>();
        rgbd = transform.GetComponent<Rigidbody>();
        currentCdMoving = maxCdMoving + Random.Range(0f, 1f);
        currentCdPausing = maxCdPausing + Random.Range(0f, 0.25f);
        currentCdAttacking = maxCdAttacking;
        currentCdFleeing = maxCdFleeing;
        gang1 = GameObject.FindGameObjectWithTag("Gang1").GetComponent<GangManager>();
        gang2 = GameObject.FindGameObjectWithTag("Gang2").GetComponent<GangManager>();
        gang3 = GameObject.FindGameObjectWithTag("Gang3").GetComponent<GangManager>();
        gang4 = GameObject.FindGameObjectWithTag("Gang4").GetComponent<GangManager>();
        gangGene1 = GameObject.FindGameObjectWithTag("Generator1").GetComponent<Generation_Gangster>();
        gangGene2 = GameObject.FindGameObjectWithTag("Generator2").GetComponent<Generation_Gangster>();
        gangGene3 = GameObject.FindGameObjectWithTag("Generator3").GetComponent<Generation_Gangster>();
        gangGene4 = GameObject.FindGameObjectWithTag("Generator4").GetComponent<Generation_Gangster>();
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
                        currentEnnemi.isFleeing = false;
                        Instantiate(particuleCombat, 0.5f * (transform.position + currentEnnemi.transform.position), Quaternion.identity);
                        isMoving = false;
                        isPausing = false;
                        isFleeing = false;
                        //Debug.Log("gangster trouvé de type " + currentEnnemi.gang_appartenance);
                    }
                }
            }
        }
        if (currentCdFleeing <= 0f)
        {
            isMoving = true;
            isPausing = false;
            isAttacking = false;
            isFleeing = false;
            currentCdFleeing = maxCdFleeing;
        }
        if (currentCdMoving <= 0f)
        {
            isMoving = false;
            isPausing = true;
            isAttacking = false;
            isFleeing = false;
            currentCdMoving = maxCdMoving + Random.Range(0f, 1f);
            var angle = Random.Range(0f, 360f);
            currentDirection = new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * speed;
        }
        if (currentCdPausing <= 0f)
        {
            isPausing = false;
            isMoving = true;
            isAttacking = false;
            isFleeing = false;
            currentCdPausing = maxCdPausing + Random.Range(0f, 0.25f);
        }
        if (currentCdAttacking <= 0f)
        {
            //Debug.Log("" + gang_appartenance + "is attacking " + currentEnnemiGang);
            if (Random.Range(0f, 1f) > 0.5f)
            {
                //Debug.Log("" + gang_appartenance + "is die to " + currentEnnemiGang);
                if (gang_appartenance == 1) gang1.numberOfGangsters--;
                if (gang_appartenance == 2) gang2.numberOfGangsters--;
                if (gang_appartenance == 3) gang3.numberOfGangsters--;
                if (gang_appartenance == 4) gang4.numberOfGangsters--;
                Destroy(transform.gameObject);
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 2)
            {
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale++;
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 3)
            {
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale++;*/
            }
            else if (gang_appartenance == 1 && currentEnnemiGang == 4)
            {
                selectionGang.listeGangs[1].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale++;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 1)
            {
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 3)
            {
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale++;
            }
            else if (gang_appartenance == 2 && currentEnnemiGang == 4)
            {
                selectionGang.listeGangs[2].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale++;*/
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 1)
            {
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale--;*/
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 2)
            {
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale--;
            }
            else if (gang_appartenance == 3 && currentEnnemiGang == 4)
            {
                selectionGang.listeGangs[3].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale--;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 1)
            {
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale--;
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 2)
            {
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                /*selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale--;*/
            }
            else if (gang_appartenance == 4 && currentEnnemiGang == 3)
            {
                selectionGang.listeGangs[4].GetComponent<GangManager>().numberOfGold += 30;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale++;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale++;
            }
            isAttacking = false;
            isMoving = true;
            isFleeing = false;
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
        
        
        if (isFleeing)
        {
            isMoving = false;
            isAttacking = false;
            isAttacked = false;
            isPausing = false;
            if (gang_appartenance == 1) currentDirection = Vector3.Normalize(gangGene1.transform.position - transform.position);
            if (gang_appartenance == 2) currentDirection = Vector3.Normalize(gangGene2.transform.position - transform.position);
            if (gang_appartenance == 3) currentDirection = Vector3.Normalize(gangGene3.transform.position - transform.position);
            if (gang_appartenance == 4) currentDirection = Vector3.Normalize(gangGene4.transform.position - transform.position);
            rgbd.velocity = currentDirection * speed * 1.5f;
            currentCdFleeing -= Time.deltaTime;
        }
        else if (isMoving)
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

/* Les membres de différents gangs se déplacent dans la zone sous leur contrôle respectif pour collecter des taxes dans les habitations et étendre leur zône d'influence en combattant dans les zones frontalières
En tant que maire de cette ville, usez de vos pouvoirs pour rétablir le calme et maintenir l'équilibre entre ces gangs pour qu'aucun ne prenne le contrôle total sur la ville. */
