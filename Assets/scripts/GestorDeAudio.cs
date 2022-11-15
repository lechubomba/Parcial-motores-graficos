using System;
using UnityEngine;

public class GestorDeAudio : MonoBehaviour 
{ 
    public Sonido[] sonidos; 
    public static GestorDeAudio instancia; 
    void Awake()
    { 
        if (instancia == null) 
        { instancia = this;
        } 
        else 
        { 
            Destroy(gameObject); 
        } 
        DontDestroyOnLoad(gameObject); 
        foreach 
            (Sonido s in sonidos) 
        { 
            s.FuenteAudio = gameObject.AddComponent<AudioSource>();
            s.FuenteAudio.clip = s.ClipSonido; 
            s.FuenteAudio.volume = s.Volumen; 
            s.FuenteAudio.pitch = s.pitch; 
            s.FuenteAudio.loop = s.repetir;
         
        } 
    } 
}
