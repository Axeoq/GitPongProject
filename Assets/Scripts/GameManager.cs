using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject panelWin;
    public string winTextL;
    public string winTextR;

    public int ScoreL; 
    public int ScoreR;

    public TMP_Text UIScoreL;
    public TMP_Text UIScoreR;
    public TMP_Text UIVictory;

    public SceneHandler sceneHandler;

    public static GameManager instance; 

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        ScoreL = 0;
        ScoreR = 0;

        UIScoreL.text = ScoreL.ToString();
        UIScoreR.text = ScoreR.ToString();
    }

    public void Scoring(string wallID)
    {
        if(wallID == "GoalL")
        {
            ScoreR = ScoreR + 1;
            UIScoreR.text = ScoreR.ToString();
            scoreCheck();
        }
        else
        {
            ScoreL = ScoreL + 1;
            UIScoreL.text = ScoreL.ToString();
            scoreCheck();
        }  
    }

    private void ChangeSceneToMenu()
    {
        sceneHandler.ChangeSceneTo("Menu");
    }

    public void scoreCheck ()
    {
        if(ScoreL == 22)
        {
            UIVictory.text = winTextL;
            panelWin.SetActive(true); 
            Invoke("ChangeSceneToMenu", 2f);
        }
        else if(ScoreR == 22)
        {
            UIVictory.text = winTextR;
            panelWin.SetActive(true);
            Invoke("ChangeSceneToMenu", 2f);
        }
    }
}
