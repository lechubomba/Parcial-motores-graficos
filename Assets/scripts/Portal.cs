using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Portal : MonoBehaviour
{
    
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal") == true)
            Pausar();
    }

    public void Pausar()
    {
        if (Time.timeScale == 1)
        { 
            Time.timeScale = 0;
        }

        else
        {
          Time.timeScale = 1;
   
            
        }
    }
   
}
