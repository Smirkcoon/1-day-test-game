using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusApple : MonoBehaviour {

    public Sprite Apple;
    private GameObject[] Gribs;
    

    private float TimeForNewApple = 15;
    private bool GeneratedRandomTime = false;
    private int RandomNumberGrib;
   
    // Use this for initialization
    void Start()
    {
        TimeForNewApple = Random.Range(2, 7);
        GeneratedRandomTime = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratedRandomTime == false)
        {
            TimeForNewApple = Random.Range(2, 7);
            GeneratedRandomTime = true;
        }
        if (GeneratedRandomTime == true)
        {
            TimeForNewApple -= Time.deltaTime;  
        }
        if (TimeForNewApple <= 0)
        {
            GribAndApple();
            GeneratedRandomTime = false;
        }
    }
    void GribAndApple()
    {
        Gribs = GameObject.FindGameObjectsWithTag("Grib");
        if(Gribs.Length > 0)
        { 
            RandomNumberGrib = Random.Range(0, Gribs.Length);
            Gribs[RandomNumberGrib].GetComponent<Image>().sprite = Apple;
            Gribs[RandomNumberGrib].tag = "Apple";
        }
    }

}
