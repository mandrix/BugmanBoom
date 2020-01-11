using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{

    public GameObject referencePoint;
    
    
    private Seeker Function;
    private GameObject referenceCopy;
    private float maxX;
    private float minX;
    private float maxY;
    private float minY;
    // Unity function
    void Start()
    {
        Function = GetComponent<Seeker>();
        Call();
    }

    void Update()
    {
       
    }

    //Custom Function

    void Call() {
        if (referenceCopy) {
            Destroy(referenceCopy);
        }
        SearchCorner();
        Vector3 position = APoint();
        referenceCopy = Instantiate(referencePoint, position, transform.rotation);
        Transform t = referenceCopy.transform;
        Function.SetTarget(t);
    }

    void SearchCorner()
    {
        GameObject[] corners = GameObject.FindGameObjectsWithTag("Corners");
        maxX = corners[0].transform.position.x + corners[1].transform.position.x;
        minX = Mathf.Min(corners[0].transform.position.x, corners[1].transform.position.x);
        maxY = corners[0].transform.position.y + corners[1].transform.position.y;
        minY = Mathf.Min(corners[0].transform.position.y, corners[1].transform.position.y);
    }

    Vector3 APoint() {         
        return new Vector3(Random.Range(minX, maxX), 0, Random.Range(minY, maxY)); ;
    }

    public void Follow(Transform playerTf)
    {
        Debug.Log(playerTf.position);
    }


}

