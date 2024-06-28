using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacles : MonoBehaviour
{
    public float rotationSpeed;
    public bool rotateLeft = false;
    public bool dirChange = false;
    public float dirChangeTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dirChange)
        {
            
        }
        else
        {
            RotateObstacle();
        }
    }

    void RotateObstacle()
    {
        if (!rotateLeft)
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0) * Time.deltaTime, Space.Self);
        }
        else
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0) * Time.deltaTime, Space.Self);
        }
    }

    void ToggleRotation()
    {
        rotateLeft = !rotateLeft;
    }
}
