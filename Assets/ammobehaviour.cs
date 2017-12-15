using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammobehaviour : MonoBehaviour {


	public float velocidadDisparo;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate (Vector2.down * velocidadDisparo * Time.deltaTime);

		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("UPS");
			Camera.main.GetComponent<UI>().bullets += 1;
			Destroy (this.gameObject);
		}
	}


	void OnCameraExit()
	{
		Destroy (this.gameObject);

	}
}
