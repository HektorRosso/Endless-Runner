using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject deathScreenCanvas;

    // Show the death screen
    public void ShowDeathScreen()
    {
        deathScreenCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    // Restart the game (called by a button)
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(1);
    }

    // Quit the game (called by a button)
    public void GoBack()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
    }
}
