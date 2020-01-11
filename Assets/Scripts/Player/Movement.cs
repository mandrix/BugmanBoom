using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    [Range(1,5)]
    public float speed;

    // Unity function
    void Start()
    {

    }

    private void Update()
    {
        Vector3 Moving = rb.velocity * -1;
        if (Input.GetKey(KeyCode.A))
            Moving.x -= speed;
        else if (Input.GetKey(KeyCode.D))
            Moving.x += speed;
        else if (Input.GetKey(KeyCode.W))
            Moving.z += speed;
        else if (Input.GetKey(KeyCode.S))
            Moving.z -= speed;
        MovingObject(Moving);
    }
    

    //Custom Function
    void MovingObject(Vector3 Vector)
    {
        rb.velocity += Vector;
    }
}

