/*
Piper Abbott-Phillips
LoadToLevel2.cs
Group Project 2
Code loads the "NigeraLetter" scene on button press
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadToLevel2 : MonoBehaviour
{
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene("NigeraLetter", LoadSceneMode.Single);
        Time.timeScale = 1f;
    }
}