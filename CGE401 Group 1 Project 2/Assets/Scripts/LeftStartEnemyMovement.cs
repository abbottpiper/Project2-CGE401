﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftStartEnemyMovement : MonoBehaviour
{
    public float speed = 5f;
    public GameObject PointA;
    public GameObject PointB;

    private Rigidbody2D rb;

    private Transform currentPoint;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform;
    }

    private void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint = PointB.transform)
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.05f && currentPoint == PointB.transform)
        {
            currentPoint = PointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.05f && currentPoint == PointA.transform)
        {
            currentPoint = PointB.transform;
        }
    }
}
