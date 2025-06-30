using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision) 
   {

        if(collision.transform.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

   }
}
