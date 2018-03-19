﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
private Vector3 offset;
	public Transform  playerTransform;
	// Use this for initialization
	void Start () {
	offset = transform.position - playerTransform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = playerTransform.position + offset;
	}
}