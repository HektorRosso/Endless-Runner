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





            /*if (gamePaused == false)
            {
                Play();
            }
            else
            {
                Pause();
            }*/
    }


    /*public void Pause()
    {
        
        gamePaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
          
    }
    public void Play()
    {
        if (Time.timeScale == 0.0f)
        {
            Time.timeScale = 1f;
            pauseMenu.SetActive(false);
            gamePaused = false;
        }
    }*/

    public void counter()
    {
        count += 1;
        if (count == 1)
        {
            Time.timeScale = 0f;
            
        }
        if (count == 2)
        {
            Time.timeScale = 1f;
            
            count -= 2; 
        }

        

    }





}
