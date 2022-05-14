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
    private float speed = 2f;
    private Vector3 currentDirection;
    private float currentCdMoving = 0f;
    private float maxCdMoving = 1.5f;
    private float radius = 2f;

    public Transform transformImage;

    public bool entering = false, exiting = false;

    void Start()
    {
        rgbd = transform.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (!isAttacking)
        {
            var list = GameObject.FindGameObjectsWithTag("Gangster");
            foreach (var item in list)
            {
                if (Vector3.Distance(item.transform.position, transform.position) <= radius)
                {
                    var gangsterMove = item.GetComponent<GangsterBehaviour>();
                    if (gangsterMove.gang_appartenance != gang_appartenance)
                    {
                        isAttacking = true;
                        isMoving = false;
                        Debug.Log("gangster trouvé de type " + gangsterMove.gang_appartenance);
                    }
                }
            }
        }        

        if (currentCdMoving <= 0f)
        {
            currentCdMoving = maxCdMoving;
            var angle = Random.Range(0f, 360f);
            currentDirection = new Vector3(Mathf.Cos(angle), 0f, Mathf.Sin(angle)) * speed;
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
