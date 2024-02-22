using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public GameObject diamondPrefab;

// Start is called before the first frame update
public class Spawner : MonoBehaviour
{

Vector3 getRandomPos()
    {
        float x = Random.Range(5, 190);
        float y = 0.9f;
        float z = Random.Range(4, 194);

        Vector3 newPos = new Vector3(x, y, z);
        return newPos;

    }

    void SpawnNow()
    {
        Instantiate(diamondPrefab[Random.Range(0, 2)], getRandomPos(), Quaternion.identity);
    }

}






