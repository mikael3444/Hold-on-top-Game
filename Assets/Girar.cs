﻿using UnityEngine;
using System.Collections;

public class Girar : MonoBehaviour {
    public float speed;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, speed));
	}
}
