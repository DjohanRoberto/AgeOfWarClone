using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroopButton : MonoBehaviour
{

    [SerializeField]
    private SpawnManager spawnManager;

    [SerializeField]
    private GameObject TroopPrefab;

    // Start is called before the first frame update
    public void SpawnTroop()
    {
        spawnManager.SpawnTroop();
    }
}
