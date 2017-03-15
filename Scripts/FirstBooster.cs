﻿using UnityEngine;
using System.Collections;

public class FirstBooster : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.GetComponent<Rigidbody>().velocity * 100 * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
