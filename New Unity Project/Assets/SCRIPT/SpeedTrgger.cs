using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrgger : MonoBehaviour {


    public Rigidbody Rg { get; private set; }

    void Start()
    {
        Rg = GetComponent<Rigidbody>();
    }
    void OnTriggerExit (Collider other)
    {   
     Rg.AddForce(Vector3.forward * 500 * Time.deltaTime, ForceMode.VelocityChange);
    }
}
