using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoviment_test1 : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float speed = 2.0f;
    Animator anim;
    public SpriteRenderer playerSprite;

   
   
    private void Awake()
    {
        playerSprite = this.GetComponent<SpriteRenderer>();
        playerRb = gameObject.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
        playerRb.bodyType = RigidbodyType2D.Dynamic;
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("IsIdle", true);
        //Moviment amb velocity amb una variable

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsMovingR",true);            
            playerRb.velocity = new Vector2(speed, playerRb.velocity.y);
            
        }
        else
        {
            //anim.SetBool("IsIdle", true);
            anim.SetBool("IsMovingR", false);
        }
       
        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("IsIdle", false);
            anim.SetBool("IsMovingL", true);
            playerRb.velocity = new Vector2(-speed, playerRb.velocity.y);
            
        }
        else
        {
            //anim.SetBool("IsIdle", true);
            anim.SetBool("IsMovingL", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            playerSprite.flipY = false;
            playerRb.velocity = new Vector2(playerRb.velocity.x, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerSprite.flipY = true;
            playerRb.velocity = new Vector2(playerRb.velocity.x, -speed);
        }

        //Fa el moviment del personatge seguint els inputs.
    }
   

}
