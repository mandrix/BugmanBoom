using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 Moving = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
            Moving = Vector3.left;
        else if (Input.GetKey(KeyCode.D))
            Moving = Vector3.right;
        else if (Input.GetKey(KeyCode.W))
            Moving = Vector3.up;
        else if (Input.GetKey(KeyCode.S))
            Moving = Vector3.down;
        else
            Moving = rb.velocity * -1;
        MovingObject(Moving);
    }

    void MovingObject(Vector3 Vector)
    {
        rb.AddForce(Vector);
    }
}

