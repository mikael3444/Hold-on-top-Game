using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-5 * speed, 0), ForceMode2D.Force);
    }
}
