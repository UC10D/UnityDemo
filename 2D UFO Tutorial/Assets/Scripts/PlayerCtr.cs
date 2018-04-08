using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtr : MonoBehaviour {

	public float speech;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();

	}

	void FixedUpdate()
	{	
		float moveVertical = Input.GetAxis("Vertical");
		float moveHorizontal = Input.GetAxis("Horizontal");

		Vector2 v = new Vector2 (moveHorizontal, moveVertical);
		rb.AddForce(v * speech);
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		print ("-------------------------------");
		
		if (other.gameObject.CompareTag ("PickUp")) 
		{	
			
			other.gameObject.SetActive (false);
		}
			
	}
	

}
