using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeObject : MonoBehaviour
{
	public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("eliminateObject");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public IEnumerator eliminateObject()
	{
		yield return new WaitForSeconds(waitTime);
		Destroy(gameObject);
	}
}
