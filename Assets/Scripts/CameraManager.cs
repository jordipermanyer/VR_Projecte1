using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject camera;
    public GameObject cameraVR;
    // Start is called before the first frame update
    void Start()
    {
        camera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera.gameObject.SetActive(true);
            cameraVR.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera.gameObject.SetActive(false);
            cameraVR.gameObject.SetActive(true);
        }
    }
}
