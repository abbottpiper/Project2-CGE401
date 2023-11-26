using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
	public GameObject laser;

    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }

	IEnumerator LaserTimer()
	{
		yield return new WaitForSeconds(3);
	}
}
