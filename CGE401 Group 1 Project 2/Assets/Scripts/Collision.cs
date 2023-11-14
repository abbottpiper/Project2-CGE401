using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public Text youLose;
    public Text youWin;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemyy"))
        {
            youLose.enabled = true;
        }
        else if(collision.gameObject.CompareTag("EndGoal"))
        {
            youWin.enabled = true;
        }
    }
}
