using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDelTiempo : MonoBehaviour
{
    public float VelocidadDelTiempo = 0.1f;
    private float escalaDeTiempoInicial;
    private float fixedDeltaTimeInicial;

    void Start()
    {
        escalaDeTiempoInicial = Time.timeScale;
        fixedDeltaTimeInicial = Time.fixedDeltaTime;


    }

   
    void Update()
    {
        if(Input.GetKey("t"))
        {
            InicioControlTiempo();

        }
        if(Input.GetKeyUp("t"))
        {
            ParoControlTiempo();
        }
    }

    void InicioControlTiempo()
    {
        Time.timeScale = VelocidadDelTiempo;


    }
    void ParoControlTiempo()
    {
        Time.timeScale = escalaDeTiempoInicial;


    }
}
