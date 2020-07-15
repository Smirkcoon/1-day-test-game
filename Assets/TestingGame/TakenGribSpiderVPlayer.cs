using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakenGribSpiderVPlayer : MonoBehaviour {

    public static bool SpiderWin = false;

    private void Start()
    {
        SpiderWin = false;
        MovePlayerStage3.PlayerWin = false;
    }

    void Update () {
        GetComponent<Text>().text = MoveSpiders.GribTaken + "/" + MovePlayerStage3.GribTakenPlayer + "(118)";
        if (MoveSpiders.GribTaken > 59)
        {
            SpiderWin = true;
        }
        if (MovePlayerStage3.GribTakenPlayer > 59)
        {
            MovePlayerStage3.PlayerWin = true;
        }
       

    }
}
