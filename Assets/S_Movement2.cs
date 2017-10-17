using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Movement2 : MonoBehaviour {

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
		if (Input.GetKey (KeyCode.Keypad8) != true) {
			spriteRenderer.sprite = sprite1;
		}
		//right
		if (Input.GetKey (KeyCode.Keypad6))
			transform.Rotate (0, 0, -rotateForce * Time.deltaTime);
		//left
		if (Input.GetKey (KeyCode.Keypad4))
			transform.Rotate (0, 0, rotateForce * Time.deltaTime);

		if (Input.GetKey (KeyCode.Keypad8)) {
			rb.AddRelativeForce (new Vector2 (-forwardForce * Time.deltaTime, 0));

			spriteRenderer.sprite = sprite2;
		}
	}
		void OnTriggerEnter2D (Collider2D collision2D)
		{
			if (collision2D.gameObject.CompareTag ("Bullet1")) 
			{
				Destroy (gameObject);

				Debug.Log ("Destroyed!");
		}
	}
}
