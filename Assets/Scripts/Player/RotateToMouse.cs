using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToMouse : MonoBehaviour
{
	public Camera cam;
	public float maximumLength;

	private Vector3 pos;
	private Vector3 direction;
	private Quaternion rotation;

    // Update is called once per frame
    void Update()
    {
		if (cam)
		{
			RaycastHit hit;
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				RotateToMouseDirection(gameObject, hit.point);
				// Do something with the object that was hit by the raycast.
			}
			
		}
		else
		{
			Debug.Log("cam not set");
		}
    }

	void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
		destination = new Vector3(destination.x, 0, destination.z);
		direction = destination - obj.transform.position;
		rotation = Quaternion.LookRotation(direction);

		obj.transform.rotation = rotation;
	}

	public Quaternion getRotation()
	{
		return rotation;
	}
}
