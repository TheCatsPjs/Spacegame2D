using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_bullet : MonoBehaviour {

	public float bulletForce = 5f;
	public Rigidbody2D rb;
	public float lifetime = 8.0f;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, lifetime);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (new Vector2 (-bulletForce * Time.deltaTime, 0));


	}
}
