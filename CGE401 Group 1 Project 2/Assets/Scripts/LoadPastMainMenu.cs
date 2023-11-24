/*
Piper Abbott-Phillips
LoadPastMainMenu.cs
Group Project 2
Code controls button function and scene loading from main menu to narrative scene
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadPastMainMenu : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Narrative1", LoadSceneMode.Single);
	}
}