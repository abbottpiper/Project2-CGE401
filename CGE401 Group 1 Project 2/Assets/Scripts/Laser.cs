/* Denver Heneghan
 * Laser
 * Group Project 2
 * This script sets the laser game objects to false if the player collides with the object tagged as Button, Button1, Button2, etc... Each tag
 * corresponds to a different laser game object.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	public GameObject laser1;
	public GameObject laser2;
	public GameObject laser3;
	public GameObject laser4;
	public GameObject laser5;
	public GameObject laser6;
	public GameObject laser7;
	public GameObject laser8;
	public GameObject laser9;
	public GameObject laser10;
	public GameObject laser11;
	public GameObject laser12;

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Button")
        {
			laser2.SetActive(false);
			laser3.SetActive(false);
		}

		if (collision.gameObject.tag == "Button1")
        {
			laser1.SetActive(false);
		}

		if (collision.gameObject.tag == "Button2")
        {
			laser4.SetActive(false);
		}

		if (collision.gameObject.tag == "Button3")
        {
			laser5.SetActive(false);
		}

		if (collision.gameObject.tag == "Button4")
        {
			laser6.SetActive(false);
		}

		if (collision.gameObject.tag == "Button5")
        {
			laser7.SetActive(false);
		}

		if (collision.gameObject.tag == "Button6")
        {
			laser8.SetActive(false);
		}

		if (collision.gameObject.tag == "Button7")
        {
			laser9.SetActive(false);
		}

		if (collision.gameObject.tag == "Button8")
        {
			laser10.SetActive(false);
		}

		if (collision.gameObject.tag == "Button9")
        {
			laser11.SetActive(false);
		}
	}
}
