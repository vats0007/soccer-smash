using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    bool isPressed = false;
    public Rigidbody rb;
    public float sidewayForce = 0f;

    void Start()
    {
        rb = FindAnyObjectByType<PlayerMovement>().rb;
        sidewayForce = rb.GetComponent<PlayerMovement>().sidewayForce;
    }

    private void FixedUpdate()
    {
        if (isPressed)
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
}

    