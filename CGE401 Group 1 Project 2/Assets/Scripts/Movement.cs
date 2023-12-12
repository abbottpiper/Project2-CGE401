/* Denver Heneghan
 * Movement
 * Group Project 2
 * This script controls the movement of the player. The player object moves along the horizontal and vertical axis depending on which arrow
 * key or wasd key is hit. It moves at a speed of 12.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int Speed = 12;

    public Rigidbody2D rb;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
}
