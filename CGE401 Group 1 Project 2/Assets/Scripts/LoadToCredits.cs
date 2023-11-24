/*
Piper Abbott-Phillips
LoadToCredits.cs
Group Project 2
Code loads the "Credits" scene on button press
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadToCredits : MonoBehaviour
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