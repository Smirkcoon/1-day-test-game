using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour {

    public Transform Player;
    private int PosX;
    private int PosY;
    private float Speed = 2;
    private Vector3 target;
    private Vector3 currentPosition;
    


    void Update()
    {
        if (Player)
        {
            
            PosX = Mathf.RoundToInt(Player.position.x);
            PosY = Mathf.RoundToInt(Player.position.y);
            target = new Vector3(PosX, PosY, transform.position.z);
            currentPosition = Vector3.Lerp(transform.position, target, Speed * Time.deltaTime);
            transform.position = currentPosition;
        }
    }
}

