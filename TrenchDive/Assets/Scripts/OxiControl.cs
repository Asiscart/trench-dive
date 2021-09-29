using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OxiControl : MonoBehaviour
{
    float oxigen = 100f;
    float oxiValue = 0.2f;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        oxigen -= oxiValue * Time.deltaTime;
        slider.value = oxigen;
        if (oxigen < 25f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
