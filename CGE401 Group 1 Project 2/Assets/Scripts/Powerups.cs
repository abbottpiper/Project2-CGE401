/* Denver Heneghan
 * Powerups
 * Group Project 2
 * This script handles the powerups. If the z key is hit, a sprite appears that hides the player object. This sprite will follow the player
 * object until it disappears after a certain amount of time. If the mouse button is clicked, it temporally disables an enemy object. After
 * a certain amount of time, the enemy object reappears. There are also two bools that need to be true for this to work. They are set to false
 * after the initial click, and then set to true again after a certain amount of time. This prevents spamming. This script also controls two
 * images, which are disabled on click and enabled after a certain amount of time. This lets the player know what is available for them to do.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerups : MonoBehaviour
{
    public GameObject Smoke;
    public GameObject Mummy;

    public Image Hide;
    public Image Shoot;

    private bool isClick = true;
    private bool isClickMummy = true;

    void Start()
    {
        Smoke.SetActive(false);
        Hide.enabled = true;
        Shoot.enabled = true;
        Mummy.SetActive(true);
    }

    void Update()
    {
        SmokeBombPowerUp();
        DartGunPowerUp();
    }

    void DartGunPowerUp()
    {
        if (isClickMummy == true && Input.GetMouseButtonDown(0))
        {
            Mummy.SetActive(false);
            StartCoroutine(DartGun());
            StartCoroutine(DartTimer());
        }
    }

    void SmokeBombPowerUp()
    {
        if (isClick == true && Input.GetKeyDown(KeyCode.Z))
        {
            Smoke.SetActive(true);
            StartCoroutine(SmokeBomb());
            StartCoroutine(Timer());
        }
    }

    IEnumerator DartGun()
    {
        Shoot.enabled = false;
        isClickMummy = false;
        yield return new WaitForSeconds(10);
        Mummy.SetActive(true);
    }

    IEnumerator DartTimer()
    {
        yield return new WaitForSeconds(45);
        isClickMummy = true;
        Shoot.enabled = true;
    }

    IEnumerator SmokeBomb()
    {
        Hide.enabled = false;
        yield return new WaitForSeconds(5);
        Smoke.SetActive(false);
        isClick = false;
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(30);

        isClick = true;
        Hide.enabled = true;
    }
}