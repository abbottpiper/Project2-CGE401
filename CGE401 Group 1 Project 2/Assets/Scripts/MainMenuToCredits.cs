/*
Piper Abbott-Phillips
MainMenuToCredits.cs
Group Project 2
Code allows a button press to load the next scene. It is no longer used in the game
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class MainMenuToCredits : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Credits", LoadSceneMode.Single);
	}
}