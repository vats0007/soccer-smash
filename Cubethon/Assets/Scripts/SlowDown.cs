using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
    private Rigidbody rb;
    public float Force;
    void Start()
    {
        rb = FindAnyObjectByType<PlayerCollision>().movement.rb;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            rb.AddForce(0, 0, -Force * Time.deltaTime, ForceMode.Impulse);
        }
    }
}
