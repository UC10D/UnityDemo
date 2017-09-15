using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    private Rigidbody rb;

    public Text text;
  
	// Use this for initialization
	void Start () {
        rb = (Rigidbody)GetComponent("Rigidbody");
	}
	
	// Update is called once per frame
	void Update () {
        //rb.AddForce(new Vector3(1, 0, 0));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0, v));

        //text.text = String.Format("世界坐标 x:{0}, y:{1}  z:{2}", transform.position.x, transform.position.y, transform.position.z);  

	}

    void OnCollisionStay(Collision collisionInfo) {
       // text.text = collisionInfo.collider.name;
        Debug.Log("----------------------" + collisionInfo.collider.name);

        if (collisionInfo.collider.name == "Cube")
        {
            Destroy(collisionInfo.gameObject);
            text.text = "游戏结束";
        
        }
    }
}
