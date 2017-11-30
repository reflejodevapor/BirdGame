using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour
{
	public float scrollSpeed;
	public float tilesizeZ;
	public GameObject tope;

	private Vector3 startPosition;

	void Start()
	{
		//startPosition = transform.position;
	}

	void Update()
	{

		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, tilesizeZ);
		this.transform.Translate (Vector2.up * Time.deltaTime * scrollSpeed);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("piedeimagen"))
		{
			this.transform.position = this.transform.position - new Vector3 (0, tilesizeZ, 0);
		}
	}
}