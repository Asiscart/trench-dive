using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPezAnim : MonoBehaviour
{
    public cambiarPunts cambiar;
    public Vida Vida;
    Collider2D col;
    public int vidaPez = 3;
    bool hurt=false;
    Animator anim;
    int pezDmg = 1;
    public bool pezDead = false;
    
    // Start is called before the first frame update
    void Start()
    {
        col = this.GetComponent<BoxCollider2D>();
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hurt)
        {
            
            anim.SetBool("PezHerido", true);
            
            
        }
        else
        {
            hurt = false;
            anim.SetBool("PezHerido", false);
        }
        if (vidaPez == 0)
        {
            cambiar.sumarPunts();
            //pezDead = true;
            Destroy(gameObject);
            


        }
        
        //Determina l'animació de hurt del peix i quan se l'ha matat. 
    }
    

    //Quan el box collider del peix entra en contacte amb el player, el player rep mal.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            
            Vida.PlayerRecibeDmg();
            
        }
     
    }
    //Quan el box collider del peix entra en contacte amb el collider del puny, el peix rep mal i s'activa l'animació de hurt.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            hurt = true;
            vidaPez--; 
            

        }
        
    }

}
