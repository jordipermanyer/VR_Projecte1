using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeKiller : MonoBehaviour
{

    //TODO: Destruir l'objecte quan entra en el trigger

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
  
}
