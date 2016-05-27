using UnityEngine;
using System.Collections;

public class ColiderDetect : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.tag == "Plataform")
        {
           // GetComponent<Animator>().SetInteger("num", 1);
        }
        if (other.gameObject.tag == "Hipogrifo")
        {
           // GetComponent<Animator>().SetInteger("num", -1);
        }
    }
}
