/* Denver Heneghan
 * Powerups
 * Group Project 2
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public GameObject Smoke;

    private bool isClick = true;

    void Start()
    {
        Smoke.SetActive(false);
    }

    void Update()
    {
        if (isClick == true && Input.GetKeyDown(KeyCode.Z))
        {
            Smoke.SetActive(true);
            StartCoroutine(SmokeBomb());
            StartCoroutine(Timer());
        }
    }

    IEnumerator SmokeBomb()
    {
        yield return new WaitForSeconds(6);
        Smoke.SetActive(false);
        isClick = false;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10);
        isClick = true;
    }
}
