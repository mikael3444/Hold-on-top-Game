using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    public float Jump;
   
    public float speed;
    public float scale;
   public Animator playerAnim;
    public float target;
    public float finaltarget;
    public float step;
    string animAtual;
   Vector2 inicio;
    Vector2 fim;
    bool tocou;
    Rigidbody2D rgd2;
  
    void Start() {
        scale = transform.localScale.x;
        rgd2 = GetComponent<Rigidbody2D>();
        playerAnim.SetBool("pulo", false);
        playerAnim.SetBool("run", false);
        playerAnim.SetBool("ataque", false);
    }

  public  float TsemAtaque = 1;
  public  float TcomAtaque = 1;
    public float TLimitAtaque = 0.5f;
void Update () {
        TsemAtaque = TsemAtaque+Time.deltaTime;
        playerAnim.SetBool("nochao", tocou);
        inicio = new Vector3(transform.position.x, transform.position.y +target);
        fim = new Vector3(transform.position.x, transform.position.y + finaltarget); 

        tocou = Physics2D.Linecast(inicio, fim);
       
        Debug.DrawLine(inicio, fim,Color.red);

        if (Input.GetKeyDown(KeyCode.Z) && TsemAtaque > TLimitAtaque)
        {
            playerAnim.SetBool("ataque", true);
           
           
        }
        if (!playerAnim.GetBool("ataque"))
        {
            playerAnim.SetBool("pulo", false);

            if (tocou)
            {

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    rgd2.AddForce(new Vector2(0, Jump));

                    playerAnim.SetBool("pulo", true);
                    playerAnim.SetBool("run", false);



                }

              
            }
            else
            {

                playerAnim.SetBool("pulo", true);
                playerAnim.SetBool("run", false);
            }

        }

        else
        {

            Ataque();
        }

        Move();

    }
 void Ataque()
    {
        TcomAtaque = TcomAtaque + Time.deltaTime;

        if (TcomAtaque > TLimitAtaque)
            {

            playerAnim.SetBool("ataque", false);
            TcomAtaque = 0;
            
        }
            else
            {
            if (playerAnim.GetBool("pulo"))
            {
               // transform.Translate(new Vector2(transform.localScale.x, 0));
            }
           

        }
        

    }
    void Move()
    {
        transform.position = new Vector2(transform.position.x + Input.GetAxis("Horizontal") * speed, transform.position.y);
        float dir = Input.GetAxis("Horizontal");

     
            if (dir < 0)
            {
                GetComponent<Transform>().localScale = new Vector3(-scale, scale, scale);

            if (tocou){
                playerAnim.SetBool("run", true);
            }

            }

            if (dir > 0)
            {

                GetComponent<Transform>().localScale = new Vector3(scale, scale, scale);



            if (tocou){
                playerAnim.SetBool("run", true);
            }


        }
            if (dir == 0)
            {
                playerAnim.SetBool("run", false);
            }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerAnim.SetBool("agachado", true);

        }else
        {
            playerAnim.SetBool("agachado", false);
        }
        }
    
    }
  
    
    

    
    
