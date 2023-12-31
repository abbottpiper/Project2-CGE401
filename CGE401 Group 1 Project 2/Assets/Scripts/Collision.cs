﻿/* Denver Heneghan
 * Collision
 * Group Project 2
 * This script keeps track of all the collisions the player object interacts with. If the player object collides with an enemy object, a 
 * counter goes up, which makes the suspicion bar go up. If the suspicion bar is filled, or the counter gets to three, then the game is over.
 * This script allows the player to restart the scene when that happens. This script also allows players to no longer be intractable with
 * enemy objects if they touch a hide object. Once they cross the notHide object then they are interactable with enemies again. If the player
 * collides with the end goal, then the player wins, and they can move to the next level. If the player interacts with the wire box object,
 * then the wire box minigame appears on screen.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public Text youLose;
    public Text youWin;

    private bool restart;
    public bool isHiding;

	private bool isTouch;
	float count = 0f;

	public Image Bar0;
	public Image Bar1;
	public Image Bar2;
	public Image Bar3;

	public Image LoseImage1;
	public Image LoseImage2;

	public Image Win;
	public Button Next;

	public Image wireBox;
	public Image Wire1;
	public Image Wire2;
	public Image Wire3;
	public Image Wire4;
	public Image Wire5;

	public Button one;
	public Button two;
	public Button three;
	public Button four;
	public Button five;

    public void Start()
    {
        youLose.enabled = false;
        youWin.enabled = false;
        restart = false;
        isHiding = false;
		isTouch = false;

		Bar0.enabled = true;
		Bar1.enabled = false;
		Bar2.enabled = false;
		Bar3.enabled = false;

		LoseImage1.enabled = false;
		LoseImage2.enabled = false;
		Win.enabled = false;
		Next.gameObject.SetActive(false);

		wireBox.enabled = false;
		Wire1.enabled = false;
		Wire2.enabled = false;
		Wire3.enabled = false;
		Wire4.enabled = false;
		Wire5.enabled = false;

		one.gameObject.SetActive(false);
		two.gameObject.SetActive(false);
		three.gameObject.SetActive(false);
		four.gameObject.SetActive(false);
		five.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restart == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            restart = false;
            Time.timeScale = 1f;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isHiding == false)
        {
			StartCoroutine(WaitTime());
        }

        if (collision.gameObject.tag == "Hide")
        {
            isHiding = true;
        }

        if(collision.gameObject.tag == "NotHide")
        {
           isHiding = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EndGoal" && isHiding == false)
        {
            youWin.enabled = true;
            Time.timeScale = 0f;
			Win.enabled = true;
			Next.gameObject.SetActive(true);
        }

		if(collision.gameObject.tag == "Laser")
		{
			StartCoroutine(WaitTime());
		}

		if(collision.gameObject.tag == "WireBox")
		{
			wireBox.enabled = true;
			Wire1.enabled = true;
			Wire2.enabled = true;
			Wire3.enabled = true;
			Wire4.enabled = true;
			Wire5.enabled = true;

			one.gameObject.SetActive(true);
			two.gameObject.SetActive(true);
			three.gameObject.SetActive(true);
			four.gameObject.SetActive(true);
			five.gameObject.SetActive(true);
		}
    }

	IEnumerator WaitTime()
	{
		count = count + 1;

		if(count == 1)
		{
			Bar0.enabled = false;
			Bar1.enabled = true;
		}

		if(count == 2)
		{
			Bar1.enabled = false;
			Bar2.enabled = true;
		}

		if(count >= 3)
		{
			Bar2.enabled = false;
			Bar3.enabled = true;
			youLose.enabled = true;
			restart = true;
			Time.timeScale = 0f;

			LoseImage1.enabled = true;
			LoseImage2.enabled = true;
		}

		yield return new WaitForSeconds(0);
	}
}
