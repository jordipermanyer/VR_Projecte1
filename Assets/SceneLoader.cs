using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadSecene(string nameScene)
    {
        ShowOverlayAndLoad(nameScene);
    }

    IEnumerator ShowOverlayAndLoad(string sceneName)
    {
        yield return new WaitForSeconds(3f);
        AsyncOperation asyncLoad;
        asyncLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
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
    }

}
