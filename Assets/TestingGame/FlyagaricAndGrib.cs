using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyagaricAndGrib : MonoBehaviour {

    private float TimeForFlyAgaric = 0;

    
	void Update ()
    {
        if (TimeForFlyAgaric <= 0 && gameObject.tag == "FlyAgaric")
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("Grib");
            gameObject.tag = "Grib";
           
        }
        if (TimeForFlyAgaric > 0)
        {
            GetComponent<Image>().sprite = Resources.Load<Sprite>("FlyAgaric");
            TimeForFlyAgaric -= Time.deltaTime;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.tag = "FlyAgaric";
            TimeForFlyAgaric = 5;
        }
    }
}
