using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : HeroBase {

	private new Collider collider;

	void Start () {
		collider = GetComponent<Collider>();
	}
	
	new void Update () {
		base.Update();
	}
}
