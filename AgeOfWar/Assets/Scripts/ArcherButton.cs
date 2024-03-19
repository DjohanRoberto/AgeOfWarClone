using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherButton : MonoBehaviour
{
    [SerializeField]
    private SpawnManager spawnManager;

    [SerializeField]
    private GameObject ArcherPrefab;

    // Start is called before the first frame update
    public void SpawnArcher()
    {
        spawnManager.SpawnArcher();
    }
}
