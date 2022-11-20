using UnityEngine;
public class GameManager : MonoBehaviour 
{
    private void Start() 
    {
        GestorDeAudio.instancia.ReproducirSonido("bombos");
    }
    
    //con el codigo de arribase pone el corre si apretas espacio
}