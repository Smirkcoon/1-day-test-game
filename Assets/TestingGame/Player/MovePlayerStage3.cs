﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayerStage3 : MonoBehaviour {

    public static int GribTakenPlayer = 0;
    public static bool PlayerWin = false;

    public GameObject Health1;
    public GameObject Health2;
    public GameObject Health3;

    public Transform PointForReborn1;
    public Transform PointForReborn2;
    public Transform PointForReborn3;
    public Transform PointForReborn4;

    private int RandomIntForPoint = 1;
    private Vector3 FixPointForReborn;

    private int speed = 7;

    private int Health = 2;

    public GameObject BubbleActive;
    private bool Bubble = false;
    private float Bubbletime = 4;

    private bool BonusActiv = false;

    public AudioSource EatSound;

    void Start()
    {
        GribTakenPlayer = 0;
        PlayerWin = false;
        BubbleActive.SetActive(false);
        Health3.SetActive(false);
    }
    void Update()
    {
        if (ScoreTStage3.ScoreStage3 >= 2000 && BonusActiv == false)
        {
            HealthBonusSound.HealthSoundActivated = true;
            Health += 1;
            FixHealthBonus();
            BonusActiv = true;            
        }
        if (Bubble == true)
        {
            Bubbletime -= Time.deltaTime;
            if (Bubbletime <= 0)
            {
                Bubbletime = 4;
                BubbleActive.SetActive(false);
                Bubble = false;
            }
        }
        float translationV = Input.GetAxis("Vertical") * speed;
        float translationH = Input.GetAxis("Horizontal") * speed;
        translationV *= Time.deltaTime;
        translationH *= Time.deltaTime;
        transform.Translate(translationH, translationV, 0);

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Grib")
        {
            col.gameObject.SetActive(false);
            ScoreTStage3.ScoreStage3 += 100;
            EatSound.Play();
            GribTakenPlayer += 1;
        }
        if (col.gameObject.tag == "FlyAgaric")
        {
            col.gameObject.SetActive(false);
            GribTakenPlayer += 1;
            if (Bubble == false)
            {
                FixHealthAndRebornAndBubble();
                EatSound.Play();
            }
        }
        if (col.gameObject.tag == "Apple")
        {
            col.gameObject.SetActive(false);
            ScoreTStage3.ScoreStage3 += 500;
            EatSound.Play();
            GribTakenPlayer += 1;
        }
        if (col.gameObject.tag == "Enemy" && Bubble == false)
        {
            FixHealthAndRebornAndBubble();
        }
        if (col.gameObject.tag == "Spider" && Bubble == false)
        {
            FixHealthAndRebornAndBubble();
        }
    }
    
    void FixHealthAndRebornAndBubble()
    {
        Health -= 1;
        Bubble = true;
        BubbleActive.SetActive(true);
        RandomIntForPoint = Random.Range(1, 5);
        FixPointForRebornDo();
        transform.position = FixPointForReborn;
        if (Health == 2)
        {
            Health3.SetActive(false);
        }
        if (Health == 1)
        {
            Health2.SetActive(false);
        }
        if (Health == 0)
        {
            Health1.SetActive(false);
        }
        if (Health == -1 || TakenGribSpiderVPlayer.SpiderWin == true)
        {
            HealthBonusSound.HealthSoundActivated = false;
            ScoreTStage3.ScoreStage3 = 0;
            GribTakenPlayer = 0;
            MoveSpiders.GribTaken = 0;
            TakenGribSpiderVPlayer.SpiderWin = false;
            SceneManager.LoadScene(2);
        }
    }
    void FixHealthBonus()
    {
        if (Health == 3 && Health3.activeSelf == false)
        {
            Health3.SetActive(true);
        }
        if (Health == 2 && Health2.activeSelf == false)
        {
            Health2.SetActive(true);
        }
        if (Health == 1 && Health1.activeSelf == false)
        {
            Health1.SetActive(true);
        }
    }

    void FixPointForRebornDo()
    {
        if (RandomIntForPoint == 1)
        {
            FixPointForReborn = PointForReborn1.position;
        }
        if (RandomIntForPoint == 2)
        {
            FixPointForReborn = PointForReborn2.position;
        }
        if (RandomIntForPoint == 3)
        {
            FixPointForReborn = PointForReborn3.position;
        }
        if (RandomIntForPoint == 4)
        {
            FixPointForReborn = PointForReborn4.position;
        }
    }
}
