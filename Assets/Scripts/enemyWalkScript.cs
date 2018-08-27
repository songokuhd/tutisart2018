﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWalkScript : MonoBehaviour
{
    private Vector2 direction;

    [SerializeField]
    private float speed = 2f;

    void Start()
    {
        direction = new Vector2(-1, 0);
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, transform.position + new Vector3(direction.x, direction.y, 0), speed * Time.deltaTime);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
            direction *= -1;
    }
}