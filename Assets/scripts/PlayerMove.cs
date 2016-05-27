using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float Jump;
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jump));
        }

    
	}

    
    }
