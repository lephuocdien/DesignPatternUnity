using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    Command keyQ, keyW, keyE,keyArrow;
    // Start is called before the first frame update
    void Start()
    {
        keyQ = new PerformJump();
        keyW = new PerformPunch();
        keyE = new PerformKick();
        keyArrow = new MoveForward();
        anim = actor.GetComponent<Animator>();
        Camera.main.GetComponent<CameraFollow360>().player = actor.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
        {
            keyQ.Excute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Excute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Excute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            keyArrow.Excute(anim);
        }
    }
}
