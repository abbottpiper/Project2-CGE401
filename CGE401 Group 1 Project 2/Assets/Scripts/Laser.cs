using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	public GameObject laser1;
	public GameObject laser2;
	public GameObject laser3;

	public bool laserStart;

    void Start()
    {
		laserStart = true;
    }

    // Update is called once per frame
    void Update()
    {
		StartCoroutine(LaserTimer());
    }

	IEnumerator LaserTimer()
	{
		yield return new WaitForSeconds(2);

		laser1.SetActive(true);
		laser2.SetActive(true);
		laser3.SetActive(true);

		yield return new WaitForSeconds(2);

		laser1.SetActive(false);
		laser2.SetActive(false);
		laser3.SetActive(false);

		yield return new WaitForSeconds(2);

		laser1.SetActive(true);
		laser2.SetActive(true);
		laser3.SetActive(true);

		yield return new WaitForSeconds(2);

		laser1.SetActive(false);
		laser2.SetActive(false);
		laser3.SetActive(false);
	}
}
