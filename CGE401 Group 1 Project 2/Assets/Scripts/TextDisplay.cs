/*
Piper Abbott-Phillips
TextDisplay.cs
Group Project 2
Code uses a for loop to display ui text letter by letter, until the entire string is displayed. When all the text has been displayed, it activates a button.
*/
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text textDisplay;
    public string fullText;
    public float letterDelay = 0.1f;
    public GameObject button;
    private void Start()
    {
        StartCoroutine(DisplayText());
    }

    private void Update()
    {
        if (textDisplay.text == fullText)
        {
            button.SetActive(true);
        }
    }
    IEnumerator DisplayText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            textDisplay.text = fullText.Substring(0, i);
            yield return new WaitForSeconds(letterDelay);
        }
    }
}
