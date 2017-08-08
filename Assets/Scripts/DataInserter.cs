using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataInserter : MonoBehaviour {

	string CreateUserURL="http://localhost/Builders/InsertUser.php";
	public string u;
	public string p;
	public string e;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			CreateUser (u, p, e);
		}
		
	}
	public void CreateUser(string username,string password,string email)
	{
		WWWForm form = new WWWForm ();
		form.AddField ("username_POST", username);
		form.AddField ("password_POST", password);
		form.AddField ("email_POST", email);

		WWW www = new WWW (CreateUserURL, form);
	}
}
