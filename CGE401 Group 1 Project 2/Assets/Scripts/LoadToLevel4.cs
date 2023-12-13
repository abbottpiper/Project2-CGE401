/*
Piper Abbott-Phillips
LoadToLevel4.cs
Group Project 2
Code loads the "EgyptLetter" scene on button press
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
		SceneManager.LoadScene("EgyptLetter", LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
}