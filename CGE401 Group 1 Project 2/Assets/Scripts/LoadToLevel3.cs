/*
Piper Abbott-Phillips
LoadToLevel3.cs
Group Project 2
Code loads the "Level3" scene on button press
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadToLevel3 : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("Level3", LoadSceneMode.Single);
	}
}