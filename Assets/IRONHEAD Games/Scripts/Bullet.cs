using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called before the first frame update

    //bullet speed
    public float speed = 10.5f;
    //rigidbody of the bullet
    Rigidbody m_Rigidbody;

    void Start()
    {
        m_Rigidbody= GetComponent<Rigidbody>();
        //TODO:
        //- Modificar la velocitat del rigidbody
        //- S'ha d'utilitzar com a velocitat el forward de la transform per la variable speed
        //initialize the variables
        m_Rigidbody.velocity = gameObject.transform.forward * speed;


    }

    private void Update()
    {
        Destroy(gameObject, 2.0f);
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
