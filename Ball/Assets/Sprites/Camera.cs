using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public GameObject gameObj;

    private Vector3 v3;

	// Use this for initialization
	void Start () {
        v3 = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = gameObj.transform.position + v3;
	}
}
