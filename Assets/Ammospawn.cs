using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammospawn : MonoBehaviour 
{

	public GameObject ammo;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnAmmo", 2.0f, 6.3f);
	}

	// Update is called once per frame
	void Update () {

	}

	void SpawnAmmo()
	{
		Vector2 pos = new Vector2 (Random.Range (-2.0f, 2.0f), 8.0f);
		Instantiate (ammo, pos, Quaternion.identity, null);
	}


	void OnCameraExit()
	{
		Destroy (this.gameObject);

	}
}
