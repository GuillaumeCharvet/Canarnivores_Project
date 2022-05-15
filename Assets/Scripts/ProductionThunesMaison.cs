using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionThunesMaison : MonoBehaviour
{
    public int gang_appartenance;
    private MeshFilter currentMesh;
    private GestionMaisons gestionMaisons;
    private SelectionGang selectionGang;
    public int style0ou1;

    public AudioSource audioThunes;

    void Start()
    {
        currentMesh = GetComponent<MeshFilter>();
        gestionMaisons = FindObjectOfType<GestionMaisons>();
        selectionGang = FindObjectOfType<SelectionGang>();
        UpdateMesh();
    }
    private void OnTriggerEnter(Collider other)
    {
        audioThunes.volume = 0.7f;
        audioThunes.pitch = 1.5f;
        audioThunes.Play();
        var gangster = other.GetComponent<GangsterBehaviour>();
        gang_appartenance = gangster.gang_appartenance;
        var gang = selectionGang.listeGangs[gang_appartenance].GetComponent<GangManager>();
        gang.numberOfGold += 10;
        gang.generation_Gangster.SpawnGangster();
        gangster.entering = true;
        gangster.StartCoroutineEntering();
        UpdateMesh();
    }
    private void OnTriggerExit(Collider other)
    {
        var gangster = other.GetComponent<GangsterBehaviour>();
        gangster.exiting = true;
        gangster.StartCoroutineExiting();
    }
    public void UpdateMesh()
    {
        currentMesh.mesh = gestionMaisons.listeMeshes[gang_appartenance + 5 * style0ou1];
    }

}
