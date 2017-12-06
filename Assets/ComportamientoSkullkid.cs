using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoSkullkid : MonoBehaviour {

	public float velocidadDisparo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector2.down * velocidadDisparo * Time.deltaTime);

		
	}

	private void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.CompareTag ("bullet")) 
		{
			Destroy (this);
		}
	}
}
