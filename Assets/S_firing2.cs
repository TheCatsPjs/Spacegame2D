using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_firing2 : MonoBehaviour 
{
	//some things are labeled '2' meaning these are those of the blue ship's
//	public float fireRate = 0f;
	public GameObject bullet2;
	public Transform firePoint;
	public float shootTime;

	//	float timeToFire = 0f;

	// Use this for initialization
	void Awake () 
	{
		firePoint = transform.FindChild ("bulletSpawnPos2");
		if (firePoint == null) 
		{
			Debug.LogError ("There isn't a bullet spawn for some reason. What the heck?!");
		}
	}

	// Update is called once per frame
	void Update () 
	{
		shootTime += 0.1f;

		if (shootTime > 7f)
		{
			if (Input.GetKey (KeyCode.Keypad0))
				Shoot ();
		}
	}

	void Shoot ()
	{

		Instantiate (bullet2, firePoint.transform.position, firePoint.transform.rotation);

		shootTime = 0f;

	}
}