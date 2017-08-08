using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
	public float WaitS=1.0f;
	void Start () {
		StartCoroutine(Load());
	}
	IEnumerator Load(){
		yield return new WaitForSeconds (WaitS);
		SceneManager.LoadScene("Main");
	}
}
