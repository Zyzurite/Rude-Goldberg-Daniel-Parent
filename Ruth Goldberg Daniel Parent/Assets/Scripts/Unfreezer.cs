using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unfreezer : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    private void Start()
    {
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    // Update is called once per frame
    public void Unfreeze()
    {

        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Unfreeze();
            
        }
    }
}
