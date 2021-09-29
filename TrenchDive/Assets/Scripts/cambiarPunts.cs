using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cambiarPunts : MonoBehaviour
{
    public EnemyPezAnim EnemyPezAnim;
    
    public Text puntuacio;
    int punts = 1;
    string numero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (punts == 15)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void sumarPunts()
    {
       punts++;
       numero = punts.ToString();
       puntuacio.text = numero;
       
          
    }



}
