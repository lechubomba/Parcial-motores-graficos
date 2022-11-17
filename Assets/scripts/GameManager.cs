using UnityEngine;
public class GameManager : MonoBehaviour 
{
    private void Start() 
    {
        GestorDeAudio.instancia.ReproducirSonido("bombos");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GestorDeAudio.instancia.ReproducirSonido("corre");
        }
    }
    //con el codigo de arribase pone el corre si apretas espacio
}