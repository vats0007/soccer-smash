using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpers : MonoBehaviour
{
    private Rigidbody rb;
    public float JForce;
    void Start()
    {
        rb = FindAnyObjectByType<PlayerCollision>().movement.rb;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddForce(0, JForce * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
