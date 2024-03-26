using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // troop prefabs all go below here 
    [SerializeField]
    private Troop TroopPrefab;
    [SerializeField]
    private Archer ArcherPrefab;

    private Queue<Troop> buffer = new Queue<Troop>();

    private float timer = 0f;
    private int current = -1;
    private Troop bufferedSpawn;

    // Update is called once per frame
    void Update()
    {

        if (buffer.Count > 0 || bufferedSpawn)
        {
            if (bufferedSpawn == null)
            {
                bufferedSpawn = buffer.Dequeue();
                current = bufferedSpawn.getBufferLength();
            }
            timer += Time.deltaTime;
            if (timer >= 1)
            {
                current--;
                timer = 0f;
            }
            if (current == 0)
            {
                var spawnPoint = new Vector3(-7, 0, 0);
                Instantiate(bufferedSpawn, spawnPoint, Quaternion.identity);
                if (buffer.Count > 0)
                {
                    bufferedSpawn = buffer.Dequeue();
                    current = bufferedSpawn.getBufferLength();
                }
                else
                {
                    bufferedSpawn = null;
                    current = -1;
                }
             }
        }
        
    }
        
    public void SpawnTroop()
    {
        buffer.Enqueue(TroopPrefab);
    }

    public void SpawnArcher()
    {
        buffer.Enqueue(ArcherPrefab);
    }

}
