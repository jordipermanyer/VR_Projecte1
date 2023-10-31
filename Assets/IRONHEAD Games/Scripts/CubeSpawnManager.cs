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
        while (true) // Esto hará que se ejecute infinitamente.
        {
            createCube();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void createCube()
    {
        int randomCube = Random.Range(0, Cubeprefabs.Length); // Asegúrate de usar Cubeprefabs.Length en lugar de 1.
        int randomSpawn = Random.Range(0, Spawnpoints.Length);
        Instantiate(Cubeprefabs[randomCube], Spawnpoints[randomSpawn].transform.position, Quaternion.identity);
    }

}
