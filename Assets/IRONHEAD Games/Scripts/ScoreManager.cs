using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public int currentScore; 
    public int highScore;

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
        // DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        //TODO: agafar del playerprefs un enter per llegir/desar el HighScore.
        //- Per defecte aquest highscore de playerPrefs si no s'ha llegit mai ha de ser 0.
        //- Posar el highScore en el ui text hightScoreText
        //- Setejar el currentScore com a 0 i també actualitzar el ui currentScoreText

 
    }


    public void AddScore(int scorePoint)
    {
        //TODO:
        //-Actualitzar el currentScore sumant-li scorePoint.
        //-Actualitzar el currentScoreText

        //- Actualitzar el finalScoreText (és la UI més gran que es mostra quan la partida finalitza)
        //- Si el currentScore supera el HighScore-->
        //  - Desar en playerprefs el nou record.
        //  - Mostrar aquesta info en el hightScoreText (la ui que es mostra al final)
        
    }
}
