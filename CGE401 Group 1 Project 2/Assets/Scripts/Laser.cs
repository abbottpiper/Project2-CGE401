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
		while(laserStart == true)
		{
			laser.SetActive(true);
			StartCoroutine(LaserTimer());
			laser.SetActive(false);
			StartCoroutine(LaserTimer());
		}
    }

	IEnumerator LaserTimer()
	{
		yield return new WaitForSeconds(2);
	}
}
