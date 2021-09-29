using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque_Test : MonoBehaviour
{
    public Animator animator;
    public int plDmg = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {

            animator.SetBool("AtacandoIzq", true);

        }
        else
        {
            animator.SetBool("AtacandoIzq", false);
            animator.SetBool("IsIdle", true);
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {

            animator.SetBool("AtacandoDer", true);

        }
        else
        {
            animator.SetBool("AtacandoDer", false);
            animator.SetBool("IsIdle", true);
        }


    }
    void Ataque()
    {
        
        //Activar l'animació d'atac
        animator.SetBool("AtacandoIzq", true);
    }
}
