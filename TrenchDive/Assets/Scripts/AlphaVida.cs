using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaVida : MonoBehaviour
{
    public Image partVida;
    public Image tempColor;
    
    private void Start()
    {
      
    }
    public void Vida03Full()
    {
              
        partVida = GetComponent<Image>();
        var tempColor = partVida.color;
        tempColor.a = 1f;
        partVida.color = tempColor;
        //Canvia l'alpha de la imatge UI de la vida

    }
    public void Vida03Mitad()
    {
        partVida = GetComponent<Image>();
        var tempColor = partVida.color;
        tempColor.a = 0.5f;
        partVida.color = tempColor;
    }
    public void Vida03Buit()
    {
        partVida = GetComponent<Image>();
        var tempColor = partVida.color;
        tempColor.a = 0f;
        partVida.color = tempColor;
    }
}
