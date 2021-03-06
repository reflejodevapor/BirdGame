﻿using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour
{
	public float scrollSpeed;
	public float tilesizeZ;
	public GameObject tope;
	private Vector3 startPosition;
	public MeshRenderer m1;
	public Material[] memes;

	void Start()
	{
	}

	void Update()
	{

		this.transform.Translate (Vector2.up * Time.deltaTime * scrollSpeed);

		if (IsVisibleInCamera () == false && this.transform.position.y < -10.0f)
		{
			this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y - (m1.bounds.max.y * 4),0);
			m1.material = memes [Random.Range (0, 2)];
		}
	}

	public bool IsVisibleInCamera()
        {
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
            return GeometryUtility.TestPlanesAABB(planes, m1.bounds);
        }


}