using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    public GameObject overlay_background;
    public GameObject overlay_LoadingText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadSecene(string nameScene)
    {
        StartCoroutine(ShowOverlayAndLoad(nameScene));
       
    }

    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        print("Canvi escena");
        overlay_background.SetActive(true);
        overlay_LoadingText.SetActive(true);

        GameObject centerEyeAnchor = GameObject.Find("CenterEyeAnchor");
        overlay_LoadingText.gameObject.transform.position = centerEyeAnchor.transform.position +
        new Vector3(0f, 0f, 3f);
        yield return new WaitForSeconds(3f);
        AsyncOperation asyncLoad;
        asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        overlay_background.SetActive(false);
        overlay_LoadingText.SetActive(false);
        yield return null;

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
        DontDestroyOnLoad(gameObject);
    }

}
