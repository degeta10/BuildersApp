using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonAndChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void ChangeScene(string scenename)
	{
		SceneManager.LoadSceneAsync(scenename);
	}
	public void BackButton()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey (KeyCode.Escape)) {				
				ChangeScene ("Main");
				return;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		BackButton ();
	}
}
