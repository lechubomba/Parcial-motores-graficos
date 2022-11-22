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

   
    void Update()
    {
        
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("portal") == true)
        {
            Time.timeScale = 0;
        }
        



    }
}
