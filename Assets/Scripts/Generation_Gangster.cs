using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Gangster : MonoBehaviour
{
    public GangManager gangManager;
    public int gang_appartenance;
    public GameObject prefab_Gangster;
    private int coutGangster = 50;

    private void Start()
    {
        SpawnGangster();
        SpawnGangster();
    }

    public void SpawnGangster()
    {
        if (gangManager.numberOfGold >= coutGangster)
        {
            gangManager.numberOfGold -= coutGangster;
            gangManager.numberOfGangsters++;
            var newGangster = Instantiate(prefab_Gangster, transform.position, Quaternion.identity, transform);
            newGangster.name = "gangster" + gangManager.numberOfGangsters + "duGang" + gang_appartenance;
            newGangster.GetComponent<GangsterBehaviour>().gang_appartenance = gang_appartenance;
            newGangster.layer = 5 + gang_appartenance;
        }
    }
}
