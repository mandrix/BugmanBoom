using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class UseAbility : MonoBehaviour
{

	public GameObject firePoint;
	public List<GameObject> vfx = new List<GameObject>();
	public RotateToMouse rotateToMouse;
	public AudioSource abilityAudio;


	private GameObject effectToSpawn;
	private float timeToFire;

    // Start is called before the first frame update
    void Start()
    {
		effectToSpawn = vfx[0];
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButton(0) && Time.time >= timeToFire)
		{
			timeToFire = Time.time + 1 / effectToSpawn.GetComponent<MoveProjectile>().fireRate;
			SpawnVFX();
		}
    }

	void SpawnVFX()
	{
		if (firePoint)
		{
			vfx.Add(Instantiate(effectToSpawn, firePoint.transform.position, Quaternion.identity));
			abilityAudio.Play(0);
			if (rotateToMouse)
			{
				vfx[vfx.Count - 1].transform.localRotation = rotateToMouse.getRotation();
			}
		}
		else
		{
			Debug.Log("firepoint is null");
		}
	}
}
