using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour {

	float floatOffset;
	public Rigidbody body;
	public new Collider collider;

	public void Awake()
	{
		body = GetComponentInChildren<Rigidbody>();
		collider = GetComponentInChildren<Collider>();
		floatOffset = Random.Range(0, 40);
	}

	void Start () {
	}
	
	void Update () {
		Float();
	}

	public void Float()
	{
		transform.Translate(Vector3.up * Mathf.Sin((Time.time + floatOffset) * 2) * .004f, Space.World);
	}
}
