using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public AudioSource death;
    public AudioSource laugh;
    public AudioSource gameOver;

    // Start is called before the first frame update
    void Start()
    {
        //gameOver = GetComponent<AudioSource>();
        //death = GetComponent<AudioSource>();
        //laugh = GetComponent<AudioClip>();

        //gameOver.PlayOneShot(death);
        //gameOver.PlayOneShot(laugh);

        gameOver.Play();
        //invoke;
    }

    private void deathSound()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
