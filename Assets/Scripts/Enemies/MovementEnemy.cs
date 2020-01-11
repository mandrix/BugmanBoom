using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    // Unity function
    void Start()
    {

    }

    void Update()
    {

    }

    //Custom Function

    public void follow(Transform playerTf)
    {
        Debug.Log(playerTf.position);
    }
}

