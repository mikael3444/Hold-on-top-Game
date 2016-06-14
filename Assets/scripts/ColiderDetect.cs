using UnityEngine;
using System.Collections;

public class ColiderDetect : MonoBehaviour {
    public Transform Player;
    void OnCollisionEnter2D(Collision2D other)

    {
        if (other.gameObject.tag == "Plataform")
        {
           //sssssssssssssss Player.GetComponent<Animator>().SetInteger("num", 1);
        }
        if (other.gameObject.tag == "Hipogrifo")
        {
          // Player.GetComponent<Animator>().SetInteger("num", -1);
        }
    }
}
