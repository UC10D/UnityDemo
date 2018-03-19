using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roll : MonoBehaviour {

		private Rigidbody rd;
		public int speed = 5;
		public Text text;
		public GameObject winText;
		private int value = 0;
		
		//取得组件


		void Start () {

		rd  = GetComponent<Rigidbody>();

		//得到当前游戏物体上的刚体组件

	}
	
		void Update () {

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		rd.AddForce(new Vector3(h,0,v) * speed );
		               //vector3(x,y,z)
		

	}
		void OnCollisionEnter (Collision collision) {

		if (collision.collider.tag == "food") {
		
			Destroy (collision.collider.gameObject);
		}
		
	}

	void OnTriggerEnter (Collider collider){
	
		if (collider.tag == "food") {
			
			value++;
			text.text = value.ToString ();
			if (value  == 4) {
				winText.SetActive(true);
			}
			Destroy (collider.gameObject);
		}
	}
}