using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public int currentScore; 
    public int highScore;
    private string clavePlayerPref = "puntuacion";

    [Header("UI Fields")]
    public TextMeshProUGUI hightScoreText;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI finalScoreText;



    public static ScoreManager instance;

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




    // Start is called before the first frame update
    void Start()
    {
        //TODO: agafar del playerprefs un enter per llegir/desar el HighScore.
        //- Per defecte aquest highscore de playerPrefs si no s'ha llegit mai ha de ser 0.
        highScore= PlayerPrefs.GetInt(clavePlayerPref);
        if (highScore != 0)
        {

            highScore = PlayerPrefs.GetInt(clavePlayerPref);

            // highScore = currentScore;
        }
        else
        {
            highScore = 0;
        }
        //- Posar el highScore en el ui text hightScoreText
        hightScoreText.SetText(highScore.ToString());
        //- Setejar el currentScore com a 0 i també actualitzar el ui currentScoreText
        currentScore = 0;
        currentScoreText.SetText("0");


    }


    public void AddScore(int scorePoint)
    {
        //TODO:
        //-Actualitzar el currentScore sumant-li scorePoint
        currentScore = currentScore + scorePoint;
        //-Actualitzar el currentScoreText
        currentScoreText.SetText(currentScore.ToString());
        //- Actualitzar el finalScoreText (és la UI més gran que es mostra quan la partida finalitza)
        finalScoreText.SetText(currentScore.ToString());

        //- Si el currentScore supera el HighScore-->
        if (currentScore > highScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetInt(clavePlayerPref, highScore);
            PlayerPrefs.Save();
            hightScoreText.SetText(highScore.ToString());
        }
        //  - Desar en playerprefs el nou record.
        //  - Mostrar aquesta info en el hightScoreText (la ui que es mostra al final)

        
    }
}
