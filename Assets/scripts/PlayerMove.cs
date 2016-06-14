using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float Jump;
    float tempo= 0;
    bool isjumped = false;
     public float speed;
    public float scale;
	void Start () {
        scale = transform.localScale.x;
        
    }
	
	
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {


            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jump));
            GetComponentInChildren<Animation>().CrossFade("JumpPlayer");
            isjumped = true;

        }
        transform.position=new Vector2(transform.position.x+Input.GetAxis("Horizontal")*speed, transform.position.y);

        if (Input.GetAxis("Horizontal")>0)
        {

           GetComponent<Transform>().localScale = new Vector3(scale, scale, scale);
            GetComponentInChildren<Animation>().CrossFade("RunPlayer");
            isjumped = false;

        }

        if (Input.GetAxis("Horizontal") <0)
        {
            GetComponent<Transform>().localScale = new Vector3(-scale, scale, scale);
            GetComponentInChildren<Animation>().CrossFade("RunPlayer");
            isjumped = false;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            if (isjumped == false)
            {
                GetComponentInChildren<Animation>().CrossFade("AdlePlaye");
            }
            
        }
    }
    }

    
    
