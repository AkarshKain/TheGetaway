using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Behavior : MonoBehaviour
{
    public float speed;
    public float jump;



    public KeyCode left;
    public KeyCode right;
    public KeyCode playerJump;
    public KeyCode shoot;



    private Rigidbody2D RB;

    public Transform jumpcheck;
    public float jumpcheckrad;
    public LayerMask ground;
    public bool landed;
    public GameObject bullet;

    public Transform shootpoint;

    public AudioSource jumpsfx;
    public AudioSource shootsfx;


    private Animator anim;

    // Start is called before the first frame update
    void Start()
    { 
        RB = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        landed = Physics2D.OverlapCircle(jumpcheck.position, jumpcheckrad, ground);

        if (Input.GetKey(left))
        {
           
            RB.velocity = new Vector2(-speed, RB.velocity.y);
            
        }
        else if (Input.GetKey(right))
        {
         
            RB.velocity = new Vector2(speed, RB.velocity.y);
            
        }
        else
        {
      
            RB.velocity = new Vector2(0, RB.velocity.y);
            
        }

        if (Input.GetKeyDown(playerJump) && landed)
        {
            RB.velocity = new Vector2(RB.velocity.x, jump);
            jumpsfx.Play();

        }

        if (Input.GetKeyDown(shoot))       //This is for gun shoot
        {
            GameObject bulletclone = (GameObject)Instantiate(bullet, shootpoint.position, shootpoint.rotation);
            bulletclone.transform.localScale = transform.localScale/0.4011968f;
            anim.SetTrigger("Hit");
            shootsfx.Play();

        }

      

        if (RB.velocity.x < 0)    //flip character
        {
            transform.localScale = new Vector3(-0.1192013f, 0.1192013f, 1);

        }
        else if (RB.velocity.x > 0)
        {
            transform.localScale = new Vector3(0.1192013f, 0.1192013f, 1);

        }

        anim.SetFloat("speed", Mathf.Abs(RB.velocity.x));
        anim.SetBool("Ground", landed);
        
    } 

}
