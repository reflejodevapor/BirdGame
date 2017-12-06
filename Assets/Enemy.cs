using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject skullkid;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("SpawnEnemy", 2.0f, 1.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnEnemy()
	{
		Vector2 pos = new Vector2 (Random.Range (-2.0f, 2.0f), 8.0f);
		Instantiate (skullkid, pos, Quaternion.identity, null);
	}
}
