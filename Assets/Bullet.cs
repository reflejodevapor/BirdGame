using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public Rigidbody2D bullet;
	public float velocidadDisparo = 1.0f;
	private GameObject esto;

	// Use this for initialization
	void Start () {
		esto = this.gameObject;

	}
	
	// Update is called once per frame
	void Update () 
	{
		bullet.transform.Translate (Vector2.up * velocidadDisparo * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("bulletdestroy")) 
		{
			Destroy (esto);
		}	
	}

}
