﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //movement velocity
    public float velocity;

    public Rigidbody2D _rigidbody2D;

    public Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();        
    }

    public void Reset()
    {
        _rigidbody2D.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        _rigidbody2D.velocity = new Vector2(velocity * x, velocity * y);
    }
}
