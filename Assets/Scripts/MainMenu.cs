using UnityEngine;
using UnityEngine.SceneManagement; 
using System.Collections;
using System.Collections.Generic;
 

public class MainMenu : MonoBehaviour
{
    void Start()
    {   }
    void Update()
    {   }
    public void EscenaJuego(){
        SceneManager.LoadScene("Juego");
    }
    public void Salir(){
        Application.Quit();
    }
}
