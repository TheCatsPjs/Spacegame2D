using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Movement : MonoBehaviour {

	public Rigidbody2D rb;

	private SpriteRenderer spriteRenderer;

	//sprites
	public Sprite sprite1;
	public Sprite sprite2;

	public float forwardForce = 120f; //moving forward force
	public float rotateForce = 120f; //turning speed

	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer> (); //accessing sprite renderer
		if (spriteRenderer.sprite == null)
			spriteRenderer.sprite = sprite1; //Set sprite to Ship
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKey ("w") != true) 
			{
				spriteRenderer.sprite = sprite1;
			}

		//right
		if (Input.GetKey ("d"))
			transform.Rotate (0, 0, -rotateForce * Time.deltaTime);
		//left
		if (Input.GetKey ("a"))
			transform.Rotate (0, 0, rotateForce * Time.deltaTime);

		if (Input.GetKey ("w")) {
				rb.AddRelativeForce (new Vector2 (-forwardForce * Time.deltaTime, 0));
			
				spriteRenderer.sprite = sprite2; 
		
		}
	}

	void OnTriggerEnter2D (Collider2D collision2D)
	{
		if (collision2D.gameObject.CompareTag ("Bullet2")) 
		{
			Destroy (gameObject);

			Debug.Log ("Destroyed!");
		}
	}
}
