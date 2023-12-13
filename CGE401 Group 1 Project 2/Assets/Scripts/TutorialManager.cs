/*Piper Abbott-Phillips
 * TutorialManager.cs
 * Group Project 2
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Spacebar
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {

        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Welcome to the Heist! \n\nControl the theif with the Arrow or WASD Keys \n\nAvoid detection by guards by staying out of line-of-sight \n\nPress (Spacebar) to continue. \nGood luck!";
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
