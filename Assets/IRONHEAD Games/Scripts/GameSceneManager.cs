﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class GameSceneManager : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI timeText;
    public Image progressBarImage;
    public GameObject timerUI_Gameobject;

    [Header("Managers")]
    public GameObject cubeSpawnManager;

    //Audio related
    float audioClipLength;
    private float timeToStartGame = 5.0f;

    //Panells
    public GameObject littlePanel;
    public GameObject bigPanel;


    // Start is called before the first frame update
    void Start()
    {
        //Getting the duration of the song
        audioClipLength = AudioManager.instance.musicTheme.clip.length;
        Debug.Log(audioClipLength);

        //Starting the countdown with song
        StartCoroutine(StartCountdown(audioClipLength));

        //Resetting progress bar
        progressBarImage.fillAmount = Mathf.Clamp(0, 0, 1);

        bigPanel.SetActive(false);
        littlePanel.SetActive(true);


    }


    public IEnumerator StartCountdown(float countdownValue)
    {
        while (countdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            countdownValue -= 1;

            timeText.text = ConvertToMinAndSeconds(countdownValue);

            //TODO:
            //-Actualitzar el progressBarImage a partir del temps actual del musicTheme que té el singleton AudioManager
            


        }
        GameOver();
    }


    public void GameOver()
    {
        Debug.Log("Game Over");
        timeText.text = ConvertToMinAndSeconds(0);

        //Disable cube spawning
        cubeSpawnManager.SetActive(false);

        //Disable timer UI
        timerUI_Gameobject.SetActive(false);

        GameObject OVRCameraRig = GameObject.Find("OVRCameraRig");
        bigPanel.transform.position = OVRCameraRig.transform.position + new Vector3(0, 2, 4);
        bigPanel.SetActive(true);
        
        littlePanel.SetActive(false);

        //yield return new WaitForSeconds(5f);
        StartCoroutine(goToLobby());
        
    }

    IEnumerator goToLobby()
    {
        yield return new WaitForSeconds(5f);
        SceneLoader.instance.LoadSecene("LobbyScene");
    }


    private string ConvertToMinAndSeconds(float totalTimeInSeconds)
    {
        //TODO: Convertir de segons a MM:SS
        string timeText = "00:00";
        return timeText;
    }

  
}
