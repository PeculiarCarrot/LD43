using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HeroInput))]
[RequireComponent(typeof(Rigidbody))]
public class HeroBase : MonoBehaviour {

	private int maxAmmo, ammo;
	private HeroInput input;

	protected Rigidbody body;
	public Material outlineMaterial;
	public Material heroMaterial;

	//View-controlling variables
	public new Camera camera;
	public Camera firstPersonCam;
	private Vector3 preLerpCamPos;
	private Quaternion preLerpCamRot;

	protected void SetMaxAmmo(int max)
	{
		maxAmmo = max;
		ammo = max;
	}

	public void SetAmmo(int ammo)
	{
		this.ammo = ammo;
	}

	public int GetAmmo()
	{
		return ammo;
	}

	public int GetMaxAmmo()
	{
		return maxAmmo;
	}

	public HeroInput GetInput()
	{
		return input;
	}

	public void Reset()
	{
		foreach(MonoBehaviour c in GetComponents<MonoBehaviour>())
		{
			c.enabled = true;
		}
		body = GetComponent<Rigidbody>();

		HeroInput[] inputs = GetComponents<HeroInput>();
		camera = firstPersonCam;

		foreach (HeroInput i in inputs)
		{
			if (i.enabled)
			{
				input = i;
			}
		}
		
		GetComponent<Renderer>().material = heroMaterial;

		camera = firstPersonCam;
	}

	public void Awake () {
		Reset();
	}
	
	public void Update () {

		if(Application.isEditor && Input.GetKeyDown(KeyCode.Escape))
		{
		//	Debug.Break();
		}
	}

	public void FixedUpdate()
	{
		if(body.velocity.y > -4)
			body.velocity += new Vector3(0, -8 * Time.deltaTime, 0);
	}
}
