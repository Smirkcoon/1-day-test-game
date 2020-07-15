using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreStage2 : MonoBehaviour {

    public static int BestScoreIntStage2 = 0;
    private int BestScoreSave = 0;


    void Start()
    {
        if (PlayerPrefs.HasKey("Score2"))
        {
            BestScoreSave = PlayerPrefs.GetInt("Score2");
        }
    }


    void Update()
    {
        if (BestScoreSave > BestScoreIntStage2)
        {
            BestScoreIntStage2 = BestScoreSave;
        }
        GetComponent<Text>().text = "BestScore:" + BestScoreIntStage2;
       

    }
}
