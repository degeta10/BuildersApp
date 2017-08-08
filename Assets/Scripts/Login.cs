using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour {
	public string username;
	public string password;
	string LoginURL="http://localhost/Builders/Login.php";

	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			StartCoroutine(LogintoDB (username, password));
		}
		
	}
	IEnumerator LogintoDB(string user,string pass)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("username_POST", user);
		form.AddField ("password_POST", pass);

		WWW www = new WWW (LoginURL, form);
		yield return www;
		Debug.Log (www.text);
	}
}
