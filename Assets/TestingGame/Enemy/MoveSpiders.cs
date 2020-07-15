using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpiders : MonoBehaviour {

    public static int GribTaken = 0;
    public Transform PointForSpiders;
    private int Speed = 15;

    private float TimeStep = 2;
    private float MoveTime = 2;

    private bool Stop = false;
    // Use this for initialization
    void Start () 
    {
        GribTaken = 0;
    }
	
	// Update is called once per frame
	void Update () {
        TimeStep -= Time.deltaTime;
        if (TimeStep <= 0 && Stop == true)
        {
            MoveTime -= Time.deltaTime;
            Stop = false;
        }
        if (MoveTime <=0)
        {
            Stop = true;
            MoveTime = 2;
        }
        if (TimeStep <= 0 && Stop == false && MoveTime >0)
        {
            transform.position = Vector2.MoveTowards(transform.position, PointForSpiders.position, Speed * Time.deltaTime);
            TimeStep = Random.Range(1, 4);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Grib")
        {
            col.gameObject.SetActive(false);
            GribTaken += 1;
        }
        if (col.gameObject.tag == "FlyAgaric")
        {
            col.gameObject.SetActive(false);
            GribTaken += 1;
        }
        if (col.gameObject.tag == "Apple")
        {
            col.gameObject.SetActive(false);
            GribTaken += 1;
        }
    }
}
