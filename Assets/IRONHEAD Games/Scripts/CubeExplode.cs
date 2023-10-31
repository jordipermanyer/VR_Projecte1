using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeExplode : MonoBehaviour
{

    public GameObject shatteredObject;
    public GameObject mainCube;
    // Start is called before the first frame update
    void Start()
    {
       //TODO: activar el cub normal (mainCube) i desactivar el cub d'explosió (shatteredObject)

    }

    public void IsShot()
    {
        //TODO:
        //Si el cub ha sigut impactat per una bala -->
        //-Destruir el mainCube
        //-Activar el shatteredObject 
        //-Fer play en el component Animation del shatteredObject
        //-Destruir el shatteredObject després de 1 segon.

    }

    void OnTriggerEnter(Collider other)
    {
        //TODO:
        //-Si l'objecte que ha entrat en el trigger del cub té tag "Bullet"
        //   aleshores activar la funció IsShot

    }


}
