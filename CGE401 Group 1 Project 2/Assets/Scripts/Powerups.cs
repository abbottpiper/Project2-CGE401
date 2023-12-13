/* Denver Heneghan
 * Powerups
 * Group Project 2
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerups : MonoBehaviour
{
    public GameObject Smoke;
    public Image Hide;
    public Text HideTimer;
    private int timeNum = 35;

    private bool isClick = true;

    void Start()
    {
        Smoke.SetActive(false);
        Hide.enabled = true;
        HideTimer.enabled = false;
    }

    void Update()
    {
        if (isClick == true && Input.GetKeyDown(KeyCode.Z))
        {
            Smoke.SetActive(true);
            StartCoroutine(SmokeBomb());
            StartCoroutine(Timer());

            timeNum = 35;
        }
    }

    IEnumerator SmokeBomb()
    {
        yield return new WaitForSeconds(5);
        Hide.enabled = false;
        Smoke.SetActive(false);
        isClick = false;
        HideTimer.enabled = true;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10);

        isClick = true;
        Hide.enabled = true;

        HideTimer.enabled = false;
    }
}