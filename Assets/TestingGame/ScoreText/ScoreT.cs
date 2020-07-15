using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreT : MonoBehaviour {
    public static int Score = 0;
    
    
	void Update () {
        GetComponent<Text>().text = "" + Score;

     
        if (GameObject.Find("Grib") == null || Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Score1", Score);
            BestScore.BestScoreInt = Score;
            HealthBonusSound.HealthSoundActivated = false;
            Score = 0;
            SceneManager.LoadScene(1);
        }
    }
}
