using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curacion : MonoBehaviour
{
    public Animator animator;
    public Vida Vida;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "player")
        {
            animator.SetTrigger("PlantaPillar");
            Vida.vidaActual = 6;
            Destroy(gameObject);
        }
    }
}
