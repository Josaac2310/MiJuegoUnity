using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Victoria2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision){
        if(collision.transform.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}

