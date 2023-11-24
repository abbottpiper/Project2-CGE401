/*
Piper Abbott-Phillips
LoadPastNarrative1.cs
Group Project 2
Code controls button function and scene loading from first narrative section in order to avoid overlap with tutorial
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadPastNarrative1 : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level1", LoadSceneMode.Single);
	}
}