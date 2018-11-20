using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour {


    public float speed = 1f;


    private void Update()
    {
        if (Input.GetButton("MoveRight"))
        {
            transform.Translate(transform.right * speed);
        }
        if (Input.GetButton("MoveLeft"))
        {
            transform.Translate(-transform.right * speed);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.Translate(transform.forward * speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(-transform.forward * speed);
        }
    }

}