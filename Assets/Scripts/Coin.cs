using UnityEngine;

public class Coin : MonoBehaviour
{
    // Referencia al ScoreManager para modificar la cantidad de monedas
    public ScoreManager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        // Verificar si lo que colisiona es el jugador (usando el tag "Player")
        if (other.CompareTag("Player"))
        {
            // Llamar al método AddCoin para incrementar el contador de monedas
            scoreManager.AddCoin();

            // Destruir la moneda después de ser recogida
            Destroy(gameObject);
        }
    }
}
