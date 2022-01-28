using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject blockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, spawnpoints.Length);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            // do something
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnpoints[i].position, Quaternion.identity);
            }
        }
    }
}
