using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTStage3 : MonoBehaviour {

    public static int ScoreStage3 = 0;


    void Update()
    {
        GetComponent<Text>().text = "" + ScoreStage3;

        if ( MovePlayerStage3.PlayerWin == true || Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Score3", ScoreStage3);
            BestScoreStage3.BestScoreIntStage3 = ScoreStage3;

            HealthBonusSound.HealthSoundActivated = false;
            ScoreStage3 = 0;
            MovePlayerStage3.GribTakenPlayer = 0;
            MoveSpiders.GribTaken = 0;
            TakenGribSpiderVPlayer.SpiderWin = false;
            SceneManager.LoadScene(0);
            Debug.Log("Scene3 finish");
        }
    }
}
