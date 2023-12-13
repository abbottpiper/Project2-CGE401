/*Piper Abbott-Phillips
 * TutorialManager2.cs
 * Group Project 2
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Spacebar
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager2 : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {

        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Search for and press the buttons to deactivate the lasers. \n\nYou can also now press the Z key to throw a Smoke Bomb to get out of a sticky situation! \n\nPress (Spacebar) to continue.";
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
