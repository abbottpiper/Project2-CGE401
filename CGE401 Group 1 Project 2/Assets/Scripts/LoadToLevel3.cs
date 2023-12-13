/*
Piper Abbott-Phillips
LoadToLevel3.cs
Group Project 2
Code loads the "ChinaLetter" scene on button press
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
		SceneManager.LoadScene("ChinaLetter", LoadSceneMode.Single);
        Time.timeScale = 1f;
	}
}