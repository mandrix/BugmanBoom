using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    [Range(1,5)]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 Moving = rb.velocity * -1;
        if (Input.GetKey(KeyCode.A))
            Moving.x -= speed;
        else if (Input.GetKey(KeyCode.D))
            Moving.x += speed;
        else if (Input.GetKey(KeyCode.W))
            Moving.y += speed;
        else if (Input.GetKey(KeyCode.S))
            Moving.y -= speed;
        MovingObject(Moving);
    }

    void MovingObject(Vector3 Vector)
    {
        rb.velocity += Vector;
    }
}

