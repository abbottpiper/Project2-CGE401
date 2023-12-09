using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator myAnimation;

    public void Start()
    {
        myAnimation = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PointC")
        {
            myAnimation.SetBool("Down", true);
            myAnimation.SetBool("Up", false);
        }

        if (collision.gameObject.tag == "PointD")
        {
            myAnimation.SetBool("Down", false);
            myAnimation.SetBool("Up", true);
        }
    }
}