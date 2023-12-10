/*
Piper Abbott-Phillips
LoadPastJaque.cs
Group Project 2
Code allows a button press to load the next scene
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadPastJaque : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("AustraliaLetter", LoadSceneMode.Single);
	}
}