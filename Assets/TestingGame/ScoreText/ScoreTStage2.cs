using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTStage2 : MonoBehaviour {

    public static int ScoreStage2 = 0;


    void Update()
    {
        GetComponent<Text>().text = "" + ScoreStage2;

        if (GameObject.Find("Grib") == null || Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Score2", ScoreStage2);
            BestScoreStage2.BestScoreIntStage2 = ScoreStage2;
            HealthBonusSound.HealthSoundActivated = false;
            ScoreStage2 = 0;
            SceneManager.LoadScene(2);
        }
    }
}
