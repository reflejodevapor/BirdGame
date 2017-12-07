using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public Rigidbody2D bullet;
	public float velocidadDisparo = 1.0f;
	//public GameObject col;
	
	// Update is called once per frame
	void Update () 
	{
		bullet.transform.Translate (Vector2.up * velocidadDisparo * Time.deltaTime);
	}

	void OnBecameInvisible()
	{
		Destroy (this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		/*col = other.GetComponent<GameObject>();

		if (col.CompareTag ("bullet")) 
		{
			Destroy (col);
		}*/
	}

}
