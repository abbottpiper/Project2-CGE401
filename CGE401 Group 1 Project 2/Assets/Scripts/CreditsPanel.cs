/*
Piper Abbott-Phillips
CreditsPanel.cs
Group Project 2
This code allows the narrative panel on the credits to be disabled. It also disables the child image of the panel.
*/
using UnityEngine;
using UnityEngine.UI;

public class CreditsPanel : MonoBehaviour
{
    public GameObject tutorialPanel;
    public Text tutorialText;

    void Start()
    {
        Time.timeScale = 0f;
        tutorialPanel.SetActive(true);
        tutorialText.text = "In the aftermath of Jaque's endeavors, the Rosetta Stone found its way back to Egypt, the Benin Bronzes returned to Nigeria, The Admonitions of the Instructress to the Court Ladies graced China once more, and the early Aboriginal shield journeyed back to Australia. \n\nIn these reclaimed moments of cultural restoration, Jaque, the master thief, left a legacy not just in grand heists but in the quiet triumphs of returning what was wrongfully taken. \n\nJaque slipped back into the shadows for the last time, ready to enjoy his well earned retirement. \n\nPress the Spacebar to Continue.";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorialPanel.SetActive(false);

            
            Image uiImage = tutorialPanel.GetComponentInChildren<Image>();
            if (uiImage != null)
            {
                uiImage.gameObject.SetActive(false);
            }

            Time.timeScale = 1f;
        }
    }
}
