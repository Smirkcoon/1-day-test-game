using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSnake : MonoBehaviour {

    Animator anim;

    private Vector3 StartPos;
    private Vector3 EndPos;
    private Vector3 Direct;
    private Vector3 MoveDirect;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        StartPos = transform.position;
        EndPos = transform.position;
        anim.SetInteger("State", 4);
    }

    // Update is called once per frame
    void Update()
    {
        StartPos = transform.position;
        if (StartPos != EndPos)
        {
            Direct = EndPos - StartPos;
            MoveDirect = transform.TransformDirection(Direct);
        }

        if (MoveDirect.x >= 0.2)
        {
            anim.SetInteger("State", 4);
            EndPos = StartPos;
        }

        if (MoveDirect.x <= -0.2)
        {
            anim.SetInteger("State", 2);
            EndPos = StartPos;
        }
        if (MoveDirect.y >= 0.2)
        {
            anim.SetInteger("State", 3);
            EndPos = StartPos;
        }

        if (MoveDirect.y <= -0.2)
        {
            anim.SetInteger("State", 1);

            EndPos = StartPos;
        }
    }
}
