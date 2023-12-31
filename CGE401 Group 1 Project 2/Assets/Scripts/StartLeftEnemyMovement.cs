﻿/* Denver Heneghan
 * StartLeftEnemyMovement
 * Group Project 2
 * This causes the enemy object to start moving left along the x axis at a speed of 5. If the object collides it an object tagged PointA, the
 * object will begin to move in the opposite direction on the x axis. If the object collides with an objected tagged PointB, the object will
 * also move in the opposite direction on the x axis.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLeftEnemyMovement : MonoBehaviour
{
    private float MoveX;
    private float speed;
    private Rigidbody2D rb;
    private Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = transform.localScale;
        MoveX = -1f;
        speed = 5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PointA" || collision.gameObject.tag == "PointB")
        {
            MoveX *= -1f;
        }

        if (collision.gameObject.tag == "PointA")
        {
            transform.Rotate(0, 180, 0);
        }

        if (collision.gameObject.tag == "PointB")
        {
            transform.Rotate(0, 180, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(MoveX * speed, rb.velocity.y);
    }
}
