﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scene : MonoBehaviour
{
	[SerializeField]
	private string mainScene = "SampleScene";

	public void StartGame()
	{
		SceneManager.LoadScene(mainScene);
	}
}
