using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLeftEnemyMovement : MonoBehaviour
{
    private float MoveX;
	private float MoveY;
    private float speed;
    private Rigidbody2D rb;
    private Vector3 direction;

	int random;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = transform.localScale;
        MoveX = -1f;
		MoveY = -1f;
        speed = 5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		random = Random.Range(0,4);

        if (collision.gameObject.tag == "PointA" || collision.gameObject.tag == "PointB")
        {
           // MoveX *= -1f;
        }

		if(random == 0)
		{
			rb.velocity = new Vector2(speed, transform.position.y);
			random = Random.Range(0,4);
		}

		if(random == 1)
		{
			rb.velocity = new Vector2(speed, -transform.position.y);
			random = Random.Range(0,4);
		}

		if(random == 2)
		{
			rb.velocity = new Vector2(speed, -transform.position.x);
			random = Random.Range(0,4);
		}

		if(random == 3)
		{
			rb.velocity = new Vector2(speed, transform.position.x);
			random = Random.Range(0,4);
		}
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(MoveX * speed, rb.velocity.y);
    }
}
