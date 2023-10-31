using System.Collections;

using System.Collections.Generic;

using System.ComponentModel;

using UnityEngine;


public class MySingleton : MonoBehaviour

{


    public static MySingleton instance;

    private void Awake()

    {

        if (instance != null && instance != this)

        {

            Destroy(this.gameObject);

            return;

        }


        instance = this;

        DontDestroyOnLoad(gameObject);

    }

}
