using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void PasarATuto()
    {
        SceneManager.LoadScene(4);
    }
}
