/*
Piper Abbott-Phillips
LoadToLevel4.cs
Group Project 2
Code loads the "Level4" scene on button press
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadToLevel4 : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level4", LoadSceneMode.Single);
	}
}