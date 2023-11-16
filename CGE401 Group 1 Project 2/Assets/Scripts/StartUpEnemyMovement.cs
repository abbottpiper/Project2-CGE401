using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpEnemyMovement : MonoBehaviour
{
    private float MoveY;
    private float speed;
    private Rigidbody2D rb;
    private Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = transform.localScale;
        MoveY = 1f;
        speed = 5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PointC" || collision.gameObject.tag == "PointD")
        {
            MoveY *= -1f;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, MoveY * speed);
    }
}
