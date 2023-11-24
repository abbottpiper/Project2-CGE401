/*
Piper Abbott-Phillips
CreditsToMenu.cs
Project 2
Code contorls button functionality and scene loading from credits back to the main menu
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadToMainMenu : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}
}