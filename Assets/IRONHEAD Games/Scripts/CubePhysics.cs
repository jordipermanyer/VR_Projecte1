using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePhysics : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float force = 1f;
    // Start is called before the first frame update
    //TODO: utilitzar addforce per configurar el moviment.

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        m_Rigidbody.AddForce(-transform.forward * force);
    }
   
}
