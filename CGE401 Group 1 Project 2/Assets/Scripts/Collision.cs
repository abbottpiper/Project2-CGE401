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
    private bool isHiding;

	private bool isTouch;
	float seconds = 0f;

	public Image Bar0;
	public Image Bar1;
	public Image Bar2;
	public Image Bar3;

    public void Start()
    {
        youLose.enabled = false;
        youWin.enabled = false;
        restart = false;
        isHiding = false;
		isTouch = false;

		Bar0.enabled = true;
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
			isTouch = true;

			StartCoroutine(WaitTime());
        }
		else
		{
			isTouch = false;
		}

        if (collision.gameObject.tag == "Hide")
        {
            isHiding = true;
        }

        if(collision.gameObject.tag != "Hide")
        {
            isHiding = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EndGoal" && isHiding == false)
        {
            youWin.enabled = true;
            restart = true;
            Time.timeScale = 0f;
        }
    }

	IEnumerator WaitTime()
	{
		seconds = seconds + 1;

		if(seconds >= 3 && isTouch == true)
		{
			youLose.enabled = true;
			restart = true;
			Time.timeScale = 0f;
		}

		yield return new WaitForSeconds(0);
	}
}
