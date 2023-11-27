using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecurityCamera : MonoBehaviour
{
	public Image WireBox;
	public Image wire1;
	public Image wire2;
	public Image wire3;
	public Image wire4;
	public Image wire5;

	public int counter = 0;
	public int num = 0;

	public Button one;
	public Button two;
	public Button three;
	public Button four;
	public Button five;

	private void Update()
	{
		if(counter == 5)
		{
			WireBox.enabled = false;

			one.gameObject.SetActive(false);
			two.gameObject.SetActive(false);
			three.gameObject.SetActive(false);
			four.gameObject.SetActive(false);
			five.gameObject.SetActive(false);

			wire1.enabled = false;
			wire2.enabled = false;
			wire3.enabled = false;
			wire4.enabled = false;
			wire5.enabled = false;

			counter = 0;

			num++;
		}
	}

	public void Wire1()
	{
		counter = counter + 1;
		wire1.enabled = false;
	}

	public void Wire2()
	{
		counter++;
		wire2.enabled = false;
	}

	public void Wire3()
	{
		counter++;
		wire3.enabled = false;
	}

	public void Wire4()
	{
		counter++;
		wire4.enabled = false;
	}

	public void Wire5()
	{
		counter++;
		wire5.enabled = false;
	}
}
