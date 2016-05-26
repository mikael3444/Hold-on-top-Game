using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;

    Vector3 startPosition;

    void Start()
    {
        Vector2 movement = new Vector2(-5 * speed, 0);
        GetComponent<Rigidbody2D>().AddForce(movement, ForceMode2D.Force);
    }
}
