using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float movement;
    
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startposition;


    public void Start()
    {
        startposition = transform.position;
    }

    public void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startposition;
    }
}
