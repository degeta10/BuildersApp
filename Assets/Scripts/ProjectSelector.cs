using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProjectSelector : MonoBehaviour {

	public void ChangeScene(string scenename)
	{
		SceneManager.LoadScene(scenename);
	}
	void Update ()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey (KeyCode.Escape)) {				
				SceneManager.LoadScene ("Main");
				return;
			}
		}
	}
}
