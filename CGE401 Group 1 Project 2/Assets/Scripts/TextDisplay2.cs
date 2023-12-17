/*
Piper Abbott-Phillips
TextDisplay2.cs
Group Project 2
Code functions the same as TextDisplay, but also allows for an array of strings to be displayed. Players can click through the strings, and once they've all been displayed, the continue button is set to active.
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextDisplay2 : MonoBehaviour
{
    public Text textDisplay;
    public GameObject buttonContainer; 
    public string[] stringsToDisplay;
    private int currentStringIndex = 0;
    private bool isDisplaying = false;

    void Start()
    {
        
        textDisplay.text = "";
        
        buttonContainer.SetActive(false);

        
        DisplayNextString();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            if (!isDisplaying)
            {
              
                if (currentStringIndex < stringsToDisplay.Length)
                {
                  
                    DisplayNextString();
                }
                else
                {
                   
                    Debug.Log("All strings displayed!");
                    buttonContainer.SetActive(true);
                }
            }
        }
    }

    void DisplayNextString()
    {
        StartCoroutine(DisplayText(stringsToDisplay[currentStringIndex]));
        currentStringIndex++;
    }

    IEnumerator DisplayText(string text)
    {
        isDisplaying = true;

       
        textDisplay.text = "";

      
        for (int i = 0; i < text.Length; i++)
        {
            textDisplay.text += text[i];
            yield return new WaitForSeconds(0.04f); 
        }

        isDisplaying = false;
    }

    
    public void OnButtonClick()
    {
       
        Debug.Log("Button Clicked!");
    }
}
