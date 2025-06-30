using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI (interfaz gráfica)

public class ScoreManager : MonoBehaviour{
    // Variable para llevar el conteo de las monedas
    public int coinCount = 0;
    // Referencia al Text de UI donde se mostrará el número de monedas
    public Text coinText;
    // Método para aumentar el contador de monedas
    public void AddCoin(){
        coinCount++;
        UpdateCoinText(); // Actualiza el texto en pantalla
    }
    // Método para actualizar el texto en pantalla
    private void UpdateCoinText(){
        coinText.text = "MONEDAS: " + coinCount.ToString();
    }
}
