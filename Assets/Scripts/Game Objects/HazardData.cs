using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardData : MonoBehaviour
{
	public hazards hazard;


	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log(string.Format("{0} {1}", other, other.tag));
	}

	private void OnCollisionEnter(Collision collision)
	{
		//Debug.Log(string.Format("{0} {1}", collision, collision.gameObject.tag));
	}
}