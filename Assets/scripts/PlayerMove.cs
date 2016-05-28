using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float Jump;
    float tempo= 0;
    bool isjumped = false;
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {


            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Jump));
          
        }

        // se apertar W ele vira triger e para de colidir com o grifo por 0.3s fazendo assim com que
        //o player desce do grifo depois de 0.3s triger = false
        if (Input.GetKeyDown(KeyCode.W))
        {


            GetComponent<Collider2D>().isTrigger = true;
            isjumped = true; 
        }

        if (isjumped)
        {
            tempo += Time.deltaTime; // conta o tempo
            if (tempo>0.3f)
            {
                GetComponent<Collider2D>().isTrigger = false;
                isjumped = false;
                tempo = 0; //  reseta o tempo
            }

        }
    }

    
    }
