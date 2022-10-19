using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public class DoubleJump : MonoBehaviour
    {
        public float jumpForce = 5;
        public float groundDistance = 0.5f;

        Rigidbody rigidBody;
        bool canDoubleJump;

        void Awake()
        {
            rigidBody = GetComponent<Rigidbody>();
        }

        bool IsGrounded()
        {
            return Physics.Raycast(transform.position, Vector3.down, groundDistance);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (IsGrounded())
                {
                    rigidBody.velocity = Vector3.up * jumpForce;
                    canDoubleJump = true;
                }
                else if (canDoubleJump)
                {
                    rigidBody.velocity = Vector3.up * jumpForce;
                    canDoubleJump = false;
                }
            }
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
            cont = cont + 1;
            setearTextos();
            other.gameObject.SetActive(false);
        }
    }
}

