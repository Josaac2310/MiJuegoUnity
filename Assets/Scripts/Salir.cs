using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Salir : MonoBehaviour
{
    public void SalirJuego(){
        Application.Quit();

        Debug.Log("Salir del juego.");

    }
}
