﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   
    public float fireRate = 3.0f;
    public GameObject bulletPrefab;

    float elapsedTime;

    public Transform nozzleTransform;

 
    public Animator gunAnimator;

    
    private AudioSource audioSource;

    public GameObject slicer;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //- Només podem cridar a la funció Shoot si (Input.GetMouseButtonDown(0) i si ha passat fireRate segons



        //afegir el temps i que ho faci amb el VR
        elapsedTime += Time.deltaTime;
        /*
                if ((Input.GetMouseButtonDown(0) || (OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger) > 0.8f)) && elapsedTime >= fireRate)
                {
                    print("Pulsado");
                    Shoot();
                    elapsedTime = 0;  
                }


        */

        if ((Input.GetMouseButtonDown(0) || (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger)) && elapsedTime >= fireRate))
        {
            print("Pulsado");
            Shoot();
            elapsedTime = 0;
        }

    }

    private void Shoot()
    {
        //TODO
        //-Play audiosource gunSound del AudioManager (és un singleton).
        AudioManager.instance.gunSound.Play();     

        //-Banas de cridar al Play s'ha de posar com a position la position de nozzleTransform

        //TODO
        //-Play animation: activar el trigger anomenat "Fire" del gunAnimator
        gunAnimator.Play("Fire");


        //TODO

        //-Crear una instància de bulletPrefab a la posició de nozzleTransform i rotació identitat
        print("creat");
        GameObject gun = Instantiate(bulletPrefab, nozzleTransform.transform.position, Quaternion.identity);  
        
        //Ignorar les colisions de la bala i el pla de la espasa.
        CapsuleCollider bulletCollider = gun.GetComponent<CapsuleCollider>();
        MeshCollider slicerCollider = GameObject.Find("Slicer").GetComponent<MeshCollider>();
        Physics.IgnoreCollision(bulletCollider, slicerCollider);

        //-Posar com a forward de la instància, la forward de la nozzleTransform
        gun.transform.forward = nozzleTransform.transform.forward;


    }

   


}
