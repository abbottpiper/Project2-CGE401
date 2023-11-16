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

    public void Start()
    {
        youLose.enabled = false;
        youWin.enabled = false;
        restart = false;
        isHiding = false;
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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && isHiding == false)
        {
            youLose.enabled = true;
            restart = true;
            Time.timeScale = 0f;
        }

        if (collision.gameObject.tag == "EndGoal" && isHiding == false)
        {
            youWin.enabled = true;
            restart = true;
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hide")
        {
            isHiding = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
