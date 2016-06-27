using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    bool View;

    Vector2 VRayStart;
    Vector2 VRayEnd;
    public float RayStart = 10;
    public float RayEnd = -10;
    public Transform target;
    public GameObject Espada;
    float time = 0;
    public float TimeDead;
    bool enemydead;
    public float ViewDistance;
    float scale;
    void Start()
    {
        scale = transform.localScale.x;

    }
  
    void Update()
    {
        
      //  VRayStart = new Vector2(transform.position.x + RayStart, transform.position.y);
       // VRayEnd = new Vector2(transform.position.x + RayEnd, transform.position.y);
      //  View = Physics2D.Linecast(VRayStart, VRayEnd);


      //  Debug.DrawLine(VRayStart, VRayEnd);
        Detect();
        dead();
    }
    void Detect()
    {
        if (View)
        {
            if (target.position.x < transform.position.x)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.3f);

                GetComponent<Transform>().localScale = new Vector3(scale, scale, scale);

            }
            else
            {
                GetComponent<Transform>().localScale = new Vector3(-scale, scale, scale);
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.3f);

            }

        }else
        {
            View = false;
        }
        if (Vector2.Distance(target.position, transform.position) < ViewDistance)
        {

            View = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.transform.FindChild("vulto"))
        {
            if (other.transform.FindChild("vulto").gameObject.active)
            {

                GetComponentInChildren<Animator>().SetBool("dead", true);
                enemydead = true;

            }
        }
    }
    public void dead()
    {

      

        if (enemydead)
        {

            print("aas");
            time += Time.deltaTime;
            if (time > TimeDead)
            {
                time = 0;
                enemydead = false;
                Destroy(gameObject);

            }
        }
    }

}
