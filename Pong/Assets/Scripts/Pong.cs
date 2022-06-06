using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Pong : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startposition;

    private void Start()
    {
        startposition = transform.position;
        LaunchPong();
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startposition;
        LaunchPong();
    }

    private void LaunchPong()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
