using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Gangster : MonoBehaviour
{
    public GangManager gangManager;
    public int gang_appartenance;
    public GameObject prefab_Gangster;
    private int coutGangster = 40;
    private int coutTerrain = 120;
    public SelectionGang selectionGang;


    private void Start()
    {
        SpawnGangster();
        SpawnGangster();
    }

    public void SpawnGangster()
    {
        if (gangManager.numberOfGold >= coutGangster && gangManager.numberOfGangsters <= 10)
        {
            gangManager.numberOfGold -= coutGangster;
            gangManager.numberOfGangsters++;
            var newGangster = Instantiate(prefab_Gangster, transform.position, Quaternion.identity, transform);
            newGangster.name = "gangster" + gangManager.numberOfGangsters + "duGang" + gang_appartenance;
            newGangster.GetComponent<GangsterBehaviour>().gang_appartenance = gang_appartenance;
            newGangster.layer = 5 + gang_appartenance;
        }
        else if (gangManager.numberOfGold >= coutTerrain)
        {
            gangManager.numberOfGold -= coutTerrain;
            if (gang_appartenance == 1)
            {
                gangManager.influenceHorizontale++;
                gangManager.influenceVerticale++;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale++;
            }
            else if (gang_appartenance == 2)
            {
                gangManager.influenceHorizontale++;
                gangManager.influenceVerticale--;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceHorizontale++;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 3)
            {
                gangManager.influenceHorizontale--;
                gangManager.influenceVerticale--;
                selectionGang.listeGangs[2].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[4].GetComponent<GangManager>().influenceVerticale--;
            }
            else if (gang_appartenance == 4)
            {
                gangManager.influenceHorizontale--;
                gangManager.influenceVerticale++;
                selectionGang.listeGangs[1].GetComponent<GangManager>().influenceHorizontale--;
                selectionGang.listeGangs[3].GetComponent<GangManager>().influenceVerticale++;
            }
        }
    }
}
