﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoSkullkid : MonoBehaviour {

	public float velocidadDisparo;

	public UI iuai;

	// Use this for initialization
	void Start () {
		iuai = Camera.main.GetComponent<UI> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector2.down * velocidadDisparo * Time.deltaTime);

		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("bullet")) 
		{
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			iuai.score += 1;
		}
			
	}
}
