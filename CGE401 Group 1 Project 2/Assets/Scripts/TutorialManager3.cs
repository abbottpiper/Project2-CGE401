/*Piper Abbott-Phillips
 * TutorialManager3.cs
 * Group Project 2
 * This script pauses the game on start, displays the tutorial text, and restarts the game/disables the tutorial panel when players press Spacebar
 */
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager3 : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {

        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "Deactivate the security cameras by disconnecting the wires in the fuse boxes \nMake sure you cut them in the correct order! \nPress (Spacebar) to continue. Good luck!";
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
