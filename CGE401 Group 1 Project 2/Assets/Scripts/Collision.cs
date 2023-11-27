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
	float count = 0f;

	public Image Bar0;
	public Image Bar1;
	public Image Bar2;
	public Image Bar3;

	public Image LoseImage1;
	public Image LoseImage2;

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
            restart = true;
            Time.timeScale = 0f;
        }

		if(collision.gameObject.tag == "Laser")
		{
			StartCoroutine(WaitTime());
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
