using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnManager : MonoBehaviour
{
    public GameObject[] Spawnpoints;
    public GameObject[] Cubeprefabs;   

   
    public float spawnInterval = 2.0f; // Cambia este valor a la frecuencia deseada.

    void Start()
    {
        StartCoroutine(SpawnCubesRepeatedly());
    }

    IEnumerator SpawnCubesRepeatedly()
    {
        while (true) 
        {
            createCube();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void createCube()
    {
        int randomCube = Random.Range(0, Cubeprefabs.Length); 
        int randomSpawn = Random.Range(0, Spawnpoints.Length);
        Instantiate(Cubeprefabs[randomCube], Spawnpoints[randomSpawn].transform.position, Quaternion.identity);
    }

}
