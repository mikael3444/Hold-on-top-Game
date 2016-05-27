﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
    public float timeRespaw = 1.0f;
    public float minFly;
    public float maxFly;

    void Start()
    {
        Vector2 movement = new Vector2(-5 * speed,0);
        GetComponent<Rigidbody2D>().AddForce(movement, ForceMode2D.Force);
        InvokeRepeating("Fly", timeRespaw, timeRespaw);
    }

    void Fly()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Random.Range(minFly, maxFly)), ForceMode2D.Force);
    }

}
