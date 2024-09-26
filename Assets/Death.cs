using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{

    // Much like the Start() and Update() methods, OnTriggerEnter2D is a special Unity method that is called by Unity automatically at a specific point - in this case, when something enters the Trigger attached to this GameObject
    private void OnTriggerEnter2D(Collider2D collison)
    {
        // If the GameObject that has collided with our trigger is tagged with CleanUp...
        if (collison.gameObject.tag == "Player")
        {
            // Then we use this method to destroy it
            SceneManager.LoadScene(2);
            
        }
    }
}
