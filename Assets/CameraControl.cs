using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 7.5f;

    // Create a public reference to the player - we will assign this using the Unity editor
    public GameObject player;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();   // Get the Rigidbody2D component attached to the player

    }

    // Update is called once per frame
    void Update()
    {
        // Change our position relation to the players position
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
    }
}
