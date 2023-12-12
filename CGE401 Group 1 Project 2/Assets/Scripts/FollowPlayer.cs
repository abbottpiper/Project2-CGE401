/* Denver Heneghan
 * FollowPlayer
 * Group Project 2
 * This script allows the enemy object to move in the direction of the player at a speed of three. This script also rotates the player on the
 * x and y axis so that it is always facing the player.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	public Transform player;
	private Rigidbody2D rb;
	private Vector2 movement;
	public float moveSpeed = 3;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		rb.rotation = angle;
		direction.Normalize();
		movement = direction;
    }
	void move(Vector2 direction)
	{
		rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
	}

	void FixedUpdate()
	{
		move(movement);
	}
}
