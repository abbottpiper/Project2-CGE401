﻿/*
Piper Abbott-Phillips
LoadPastLetter3.cs
Group Project 2
Code allows a button press to load the next scene
*/
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class LoadPastLetter3 : MonoBehaviour
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