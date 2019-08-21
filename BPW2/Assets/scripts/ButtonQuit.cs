using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonQuit : MonoBehaviour
{
    
   

       void OnTriggerEnter(Collider col)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}


    
