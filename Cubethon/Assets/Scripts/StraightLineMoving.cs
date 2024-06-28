using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightLineMoving : MonoBehaviour
{
    [Header("Common Attributes For Both")]
    [SerializeField]
    private float moveSpeed = 1f;
    [SerializeField]
    private bool moveToLeft = false;

    [Header("Displacement From Origin")]
    [SerializeField]
    private float maxDisplacement = 3f;
    

    [Header("One End To The Other")]
    [SerializeField]
    private bool endToEndEnabled = false;
    [SerializeField]
    private float higherEnd;
    [SerializeField]
    private float lowerEnd;

    

    // Assuming cube is at center
    void Start()
    {
        if (!endToEndEnabled)
        {
            Vector3 startPos = transform.position;
            if (Mathf.Abs(startPos.x) > maxDisplacement)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (endToEndEnabled)
        {
            moveFromEndtoEnd();
        }
        else
        {
            moveFromOrigin();
        }
    }


    void moveFromOrigin()
    {
        if (!moveToLeft)
        {
            transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime, Space.World);
            if (transform.position.x >= maxDisplacement || transform.position.x <= -maxDisplacement)
            {
                moveSpeed = -moveSpeed;
            }
        }
        else
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime, Space.World);
            if (transform.position.x >= maxDisplacement || transform.position.x <= -maxDisplacement)
            {
                moveSpeed = -moveSpeed;
            }
        }
    }

    void moveFromEndtoEnd()
    {
        if (!moveToLeft)
        {
            transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime, Space.World);
            if (transform.position.x >= higherEnd || transform.position.x <= lowerEnd)
            {
                moveSpeed = -moveSpeed;
            }
        }
        else
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0) * Time.deltaTime, Space.World);
            if (transform.position.x >= higherEnd || transform.position.x <= lowerEnd)
            {
                moveSpeed = -moveSpeed;
            }
        }
    }
}
