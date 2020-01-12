using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
	[Range(0.5f,2)]
	public float explosionTimer;

	public GameObject explosionObj;

    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine("explodeBomb");
	}

    // Update is called once per frame
    void Update()
    {
		
    }

	public IEnumerator explodeBomb()
	{
		yield return new WaitForSeconds(explosionTimer);

		Instantiate(explosionObj, transform.position, transform.rotation);
		Destroy(gameObject);
	}
}
