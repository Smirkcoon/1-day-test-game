using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreStage3 : MonoBehaviour {

    public static int BestScoreIntStage3 = 0;
    private int BestScoreSave = 0;


    void Start()
    {
        if (PlayerPrefs.HasKey("Score3"))
        {
            BestScoreSave = PlayerPrefs.GetInt("Score3");
        }
    }


    void Update()
    {
        if (BestScoreSave > BestScoreIntStage3)
        {
            BestScoreIntStage3 = BestScoreSave;
        }
        GetComponent<Text>().text = "BestScore:" + BestScoreIntStage3;
    }
}
