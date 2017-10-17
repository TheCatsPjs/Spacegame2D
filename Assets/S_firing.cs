using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_firing : MonoBehaviour 
{

//	public float fireRate = 1f;
	public GameObject bullet1;
	public Transform firePoint;
	public float shootTime = 0f;

//	float timeToFire = 0f;

	// Use this for initialization
	void Awake () 
	{
		firePoint = transform.FindChild ("bulletSpawnPos");
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
			if (Input.GetKey (KeyCode.Space))
				Shoot ();
		}
	}

		void Shoot ()
		{
		
		Instantiate (bullet1, firePoint.transform.position, firePoint.transform.rotation);

		shootTime = 0f;

		}
}