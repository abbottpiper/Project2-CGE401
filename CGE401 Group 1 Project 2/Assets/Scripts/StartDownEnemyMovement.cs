/* Denver Heneghan
 * StartDownEnemyMovement
 * Group Project 2
 * This causes the enemy object to start moving left along the y axis at a speed of 5. If the object collides it an object tagged PointC, the
 * object will begin to move in the opposite direction on the y axis. If the object collides with an objected tagged PointD, the object will
 * also move in the opposite direction on the y axis.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDownEnemyMovement : MonoBehaviour
{
    private float MoveY;
    private float speed;
    private Rigidbody2D rb;
    private Vector3 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = transform.localScale;
        MoveY = -1f;
        speed = 5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PointC" || collision.gameObject.tag == "PointD")
        {
            MoveY *= -1f;
        }

        if(collision.gameObject.tag == "PointC")
        {
            transform.Rotate(180, 0, 0);
        }

        if (collision.gameObject.tag == "PointD")
        {
            transform.Rotate(180, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, MoveY * speed);
    }
}
