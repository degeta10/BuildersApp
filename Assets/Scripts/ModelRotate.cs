using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRotate : MonoBehaviour {
	
	private bool _rotateside;
	private bool _rotateup;
	public GameObject model;

	public void OnPressS()
	{
		_rotateside = true;
	}

	public void OnReleaseS()
	{
		_rotateside = false;
	}
	public void OnPressU()
	{
		_rotateup = true;
	}

	public void OnReleaseU()
	{
		_rotateup = false;
	}
	public void RotateSide()
	{	
		if(_rotateside)
		{
			model.transform.Rotate(Vector3.up, 1f, Space.World);
		}
	}
	public void RotateUp()
	{	
		if(_rotateup)
		{
			model.transform.Rotate(Vector3.right, 1f, Space.World);
		}
	}
	void Update()
	{
		RotateSide ();
		RotateUp ();
	}
}
