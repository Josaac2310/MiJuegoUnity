using UnityEngine;
using UnityEngine.UI; // Necesario para poder trabajar con el UI (Texto)

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb; // Referencia al Rigidbody del jugador
    private float forwardForce = 300;  // Fuerza hacia adelante
    private float sideForce = 1000;     // Fuerza lateral
    private float jumpForce = 6.0f;     // Fuerza del salto
    private bool isGrounded;            // Comprobar si el jugador está en el suelo
    public float groundCheckDistance = 1f; // Distancia del raycast al suelo
    // Referencia a la UI de puntuación
    public Text puntuacionText;

    // Start is called once before the first execution of Update after the MonoBehaviour es creado
    void Start(){
        rb.useGravity = true; //gravedad activada al empezar
    }
    void Update(){
        isGrounded = CheckIfGrounded();
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Movimiento hacia adelante
       
        // Movimiento hacia los lados
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

        // Salto (aplica la fuerza solo si el jugador está en el suelo)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Aplica la fuerza de salto
        }
        // Actualizar la puntuación basada en la posición en el eje Z
        if (puntuacionText != null) // Verificar que la referencia no es null
        {
            puntuacionText.text = "PUNTOS: " + Mathf.RoundToInt(transform.position.z).ToString(); // Mostrar la puntuación
        }
    }
    // Método para detectar si el jugador está tocando el suelo usando Raycast
    private bool CheckIfGrounded(){
        // Lanza un Raycast hacia abajo desde el centro del jugador y verifica si toca algo
        return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);
    }
    // Usando OnCollisionEnter para verificar si tocamos el "Plane"
    private void OnCollisionEnter(Collision collision){
        // Verificar si el objeto con el que hemos colisionado es el "Plane"
        if (collision.gameObject.name == "Plane")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision){
        if (collision.gameObject.name == "Plane")
        {
            isGrounded = false;
        }
    }
}
