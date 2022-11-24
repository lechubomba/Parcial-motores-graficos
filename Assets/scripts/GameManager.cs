using UnityEngine;
public class GameManager : MonoBehaviour 
{
    private void Start() 
    {
        GestorDeAudio.instancia.ReproducirSonido("bombos");
    }
    
  
}