using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlJugador : MonoBehaviour
{
    private Rigidbody rb;
    public int rapidez;
    public TMPro.TMP_Text textoCantidadRecolectados;
    public TMPro.TMP_Text textoGanaste;
    private int cont;
    public LayerMask capaPiso;
    public float magnitudSalto;
    public SphereCollider col;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();
        cont = 0;
        textoGanaste.text = "";
        setearTextos();
    }

    private void setearTextos()
    {
        textoCantidadRecolectados.text = "Collectibles collected: " + cont.ToString();
        if (cont >= 5)
        {
            textoGanaste.text = "GANASTE ";
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnPiso())
        {
            rb.AddForce(Vector3.up * magnitudSalto, ForceMode.Impulse);
        }
    }


    private bool EstaEnPiso()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, capaPiso);
    }

    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 vectorMovimiento = new Vector3(movimientoHorizontal, 0.0f, movimientoVertical);
        rb.AddForce(vectorMovimiento * rapidez);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coleccionable") == true)
        {

            rapidez = rapidez + 10;
            rb.transform.localScale = new Vector3(4f, 4f, 4f);
            cont = cont + 1;
            other.gameObject.SetActive(false);
        }
    }



    public GameObject powerup;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "powerup")
        {
            Debug.Log("Collision detected");
            powerup.GetComponent<Renderer>().enabled = false;
        }
    }
    

}

