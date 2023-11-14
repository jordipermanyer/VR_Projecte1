using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    public static Vibration instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Vibra()
    {

        StartCoroutine(createVibrationGun());

    }
    public void VibraSword()
    {

        StartCoroutine(createVibrationSword());

    }
    IEnumerator createVibrationGun()
    {
        print("Canvi escena");
        OVRInput.SetControllerVibration(2000, 2000, OVRInput.Controller.LTouch);
        // Espera 1 segundo
        yield return new WaitForSeconds(5f);

        // Detén la vibración
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
    }

    IEnumerator createVibrationSword()
    {
        print("Canvi escena");
        OVRInput.SetControllerVibration(2000, 2000, OVRInput.Controller.RTouch);
        // Espera 1 segundo
        yield return new WaitForSeconds(5f);

        // Detén la vibración
        OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
    }
}
