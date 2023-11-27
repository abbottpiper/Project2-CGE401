/*Piper Abbott-Phillips
 * TutorialManager4.cs
 * Group Project 2
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Spacebar
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager4 : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {

        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Watch out for the roaming mummy! \nPress (Spacebar) to continue. Good luck!";
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            tutorialPanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
