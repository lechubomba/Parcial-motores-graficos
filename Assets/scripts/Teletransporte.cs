using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public Transform Target;
    public GameObject jugador;

    private void OnTriggerEnter(Collider other)
    {
        jugador.transform.position=Target.transform.position;


    }
}
