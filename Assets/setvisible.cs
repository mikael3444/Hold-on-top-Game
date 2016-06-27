using UnityEngine;
using System.Collections;

public class setvisible : MonoBehaviour {

   public Animator player;
   public GameObject espada;
    public GameObject vulto;
    void Start () {
     
	}
	

	void Update () {


        if (player.GetBool("ataque"))
        {
           espada.SetActive(true);
            vulto.SetActive(true);
        }
        else
        {
            vulto.SetActive(false);
            espada.SetActive(false);
        }
	}
}
