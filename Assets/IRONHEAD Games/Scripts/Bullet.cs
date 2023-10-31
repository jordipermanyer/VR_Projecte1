using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called before the first frame update

    //bullet speed
    public float speed = 10.5f;
    //rigidbody of the bullet

    
    void Start()
    {
        //TODO:
        //- Modificar la velocitat del rigidbody
        //- S'ha d'utilitzar com a velocitat el forward de la transform per la variable speed
        //initialize the variables
        
    }

  
   
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
