using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public static int BestScoreInt = 0;
    private int BestScoreSave = 0;


    void Start ()
    {
        if (PlayerPrefs.HasKey("Score1"))
        {
            BestScoreSave = PlayerPrefs.GetInt("Score1");
        }
    }
	
	
	void Update ()
    {
        if (BestScoreSave > BestScoreInt)
        {
            BestScoreInt = BestScoreSave;
        }
        GetComponent<Text>().text = "BestScore:" + BestScoreInt;
        
        
    }
}
