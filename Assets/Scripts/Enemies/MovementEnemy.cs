using System.Collections;


using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{

    public GameObject referencePoint;
    public float time;
    private float _time;

    private Seeker Function;
    private GameObject referenceCopy;
    private float maxX;
    private float minX;
    private float maxZ;
    private float minZ;

    // Unity function
    void Start()
    {
        _time = time;
        Function = GetComponent<Seeker>();
        Call();
    }

    void Update()
    {
        if (time <= 0)
        {
            Call();
            time = _time;
        }
        time -= Time.deltaTime;

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
        minX = Mathf.Min(corners[0].transform.position.x, corners[1].transform.position.x);
        maxX = (corners[0].transform.position.x + corners[1].transform.position.x) - minX;
        minZ = Mathf.Min(corners[0].transform.position.z, corners[1].transform.position.z);
        maxZ = (corners[0].transform.position.z + corners[1].transform.position.z) - minZ;
    }

    Vector3 APoint() {
        Vector3 vec = new Vector3(Random.Range(minX, maxX), 0, Random.Range(minZ, maxZ));
        return vec ;
    }

    public void Follow(Transform playerTf)
    {
        //Debug.Log(playerTf.position);
    }


}

