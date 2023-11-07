using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   
    public float fireRate = 0.1f;
    public GameObject bulletPrefab;

    float elapsedTime;

    public Transform nozzleTransform;

 
    public Animator gunAnimator;

    private AudioManager audio;

    private void Start()
    {
         //audio = GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //TODO
        //- Només podem cridar a la funció Shoot si (Input.GetMouseButtonDown(0) i si ha passat fireRate segons

        //afegir el temps i que ho faci amb el VR
        if (Input.GetMouseButtonDown(0))
        {
            print("Polsat");
            Shoot();
        }

    }

    private void Shoot()
    {
        //TODO
        //-Play audiosource gunSound del AudioManager (és un singleton).
        //audio.gunSound.Play();
        //-Banas de cridar al Play s'ha de posar com a position la position de nozzleTransform

        //TODO
        //-Play animation: activar el trigger anomenat "Fire" del gunAnimator
        gunAnimator.Play("Fire");


        //TODO

        //-Crear una instància de bulletPrefab a la posició de nozzleTransform i rotació identitat
        print("creat");
        GameObject gun = Instantiate(bulletPrefab, nozzleTransform.transform.position, Quaternion.identity);
        //-Posar com a forward de la instància, la forward de la nozzleTransform
        gun.transform.forward = nozzleTransform.transform.forward;


    }

   


}
