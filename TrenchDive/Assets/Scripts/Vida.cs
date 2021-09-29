using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    /*pseudoCode
        la vida maxima que el personatge aguanta es 6
        cada cop que rep un cop la vida perd color, 1r cop al -50% 2n -100%
        ha de poguer detectar cuanta vida te el personatge i treure la visibilitat on toca. */
    public Animator playerAnim;
    public AlphaVida AlphaVida03;
    public AlphaVida AlphaVida02;
    public AlphaVida AlphaVida01;

    public int vidaActual = 6;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }
    public void PlayerRecibeDmg()
    {
        vidaActual--;
        playerAnim.SetTrigger("Herido");
        
    }
    public void PlayerCurar()
    {
        vidaActual = 6;
    }
    // Update is called once per frame
    void Update()
    {
        
        //Aquest switch canvia entre els diferents alphas de cada vida.
        
       switch (vidaActual)
        {
            case 6:
                AlphaVida03.Vida03Full();
                AlphaVida02.Vida03Full();
                AlphaVida01.Vida03Full();
                
                break;
            case 5:
                AlphaVida03.Vida03Mitad();
                
                break;
            case 4:
                AlphaVida03.Vida03Buit();
                break;
            case 3:
                AlphaVida02.Vida03Mitad();
                break;
            case 2:
                AlphaVida02.Vida03Buit();
                break;
            case 1:
                AlphaVida01.Vida03Mitad();
                break;
            case 0:
                AlphaVida01.Vida03Buit();
                
                break;
        }
        if (vidaActual == 0)
        {
            
            SceneManager.LoadScene(2);
        }

    }
}
