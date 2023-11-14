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
        mainCube.SetActive(true);
        shatteredObject.SetActive(false);
        

    }

    public void IsShot()
    {


        //TODO:
        //Si el cub ha sigut impactat per una bala -->
        //-Destruir el mainCube
        Destroy(mainCube);

        Vibration.instance.Vibra();

        //-Activar el shatteredObject 
        shatteredObject.SetActive(true);
        //-Fer play en el component Animation del shatteredObject
        shatteredObject.GetComponent<Animation>().Play();
        //-Destruir el shatteredObject després de 1 segon.
        Destroy(shatteredObject, 1.0f);

        ScoreManager.instance.AddScore(1);

    }

    void OnTriggerEnter(Collider other)
    {
        //TODO:
        //-Si l'objecte que ha entrat en el trigger del cub té tag "Bullet"
        //   aleshores activar la funció IsShot

        if (other.gameObject.CompareTag("Bullet"))
        {
            IsShot();
           
        }

    }


}
