using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQuit : MonoBehaviour
{
    
   

       void OnTriggerEnter(Collider col)
        {
        Application.Quit();

    }


    }
