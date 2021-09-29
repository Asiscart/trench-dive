using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxigen : MonoBehaviour
{
    public Slider slider;

    public void OxigenControl(float oxigen) //Va baixant l'oxigen fins a acabarse'l
    {
        oxigen = 100f;
        float oxiValue = 0.1f;

        oxigen -= oxiValue * Time.deltaTime;
        

        slider.value = oxigen;
        
    }
    
       

}
