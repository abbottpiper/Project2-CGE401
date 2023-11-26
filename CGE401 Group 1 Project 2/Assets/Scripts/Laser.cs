using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private bool start; 

	public GameObject laser;

    void Start()
    {
		start = true;   
    }

    // Update is called once per frame
    void Update()
    {
        while(start == true)
		{
			laser.SetActive(false);
		}
    }

	IEnumerator LaserTimer()
	{
		yield return new WaitForSeconds(3);
	}
}
