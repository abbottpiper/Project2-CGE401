using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	public GameObject laser;

	public bool laserStart;

    void Start()
    {
		laserStart = true;
    }

    // Update is called once per frame
    void Update()
    {
		do
		{
			laser.SetActive(true);
			StartCoroutine(LaserTimer());
			laser.SetActive(false);
			StartCoroutine(LaserTimer());
		} while (laserStart == true);
    }

	IEnumerator LaserTimer()
	{
		yield return new WaitForSeconds(2);
	}
}
