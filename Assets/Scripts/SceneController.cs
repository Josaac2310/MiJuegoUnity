using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para gestionar escenas

public class SceneController : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Juego");
    }
}
