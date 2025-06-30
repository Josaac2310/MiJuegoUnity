using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform player;          // Referencia al transform de la pelota (jugador)
    public Vector3 offset;            // Distancia entre la cámara y la pelota

    void Start()
    {
        // Si no has asignado un offset en el inspector, ajustamos un valor por defecto
        if (offset == Vector3.zero)
        {
            offset = new Vector3(0, 5, -7);  // Ajusta este valor según lo que necesites
        }
    }

    void Update()
    {
        // Actualizar la posición de la cámara para que siga a la pelota
        // La cámara se mueve con la pelota pero mantiene una distancia constante
        Vector3 targetPosition = player.position + offset;

        // Asignamos la posición calculada a la cámara
        transform.position = targetPosition;
    }
}
