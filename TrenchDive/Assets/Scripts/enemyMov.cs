using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMov : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    public SpriteRenderer sp;
    bool playerDetect = false;
    bool patrulla;

    // Start is called before the first frame update
    void Start()
    {
        
        
        rb = this.GetComponent<Rigidbody2D>();
        sp = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position; //calcula la diferencia de posició del player i el peix
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;  //Calcula l'angle de rotació del peix i el transforma a graus 
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;//Fa que el peix es mogui en la direcció del player
        if (angle <= -90f)//gira el sprite del peix per a que no quedi del reves depenent de l'angle
        {
            sp.flipY = true;
        }
        else
        {
            sp.flipY = false;
        }
        //Debug.Log(direction);
        //Debug.Log(movement);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            playerDetect = true;
        }
    }
    private void FixedUpdate()
    {
        if (playerDetect)
        {
            MoveCharacter(movement);

        }
        
        
        
    }
    
    void MoveCharacter(Vector2 direction)
    {
        
        
     rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));//fa que el peix es mogui
        
        
    }
}
