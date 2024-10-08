using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject PauseMenu;
    private int count = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.timeScale == 0f)
        {
            PauseMenu.SetActive(true);
        }

        if (Time.timeScale > 0f)
        {
            PauseMenu.SetActive(false);
        }
    }

    public void counter()
    {
        count += 1;
        if (count == 1)
        {
            Time.timeScale = 0f;
            AudioListener.volume = 0f;
        }
        if (count == 2)
        {
            Time.timeScale = 1f;
            
            count -= 2;

            AudioListener.volume = 1f;
        }        
    }
}
