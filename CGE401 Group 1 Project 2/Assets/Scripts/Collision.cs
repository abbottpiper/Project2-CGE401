using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public Text youLose;
    public Text youWin;

    public void Start()
    {
        youLose.enabled = false;
        youWin.enabled = false;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            youLose.enabled = true;
        }

        if(collision.gameObject.tag == "EndGoal")
        {
            youWin.enabled = true;
        }
    }
}
