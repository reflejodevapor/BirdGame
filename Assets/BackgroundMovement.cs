using UnityEngine;
using System.Collections;

public class BackgroundMovement : MonoBehaviour
{
	public float scrollSpeed;
	public float tilesizeZ;
	public GameObject tope;
	private Vector3 startPosition;
	public MeshRenderer m1;

	void Start()
	{

			startPosition = this.transform.position;


	}

	void Update()
	{

		this.transform.Translate (Vector2.up * Time.deltaTime * scrollSpeed);

		if (IsVisibleInCamera () == false) 
		{
			if (this.gameObject.CompareTag ("image1")) 
			{
				this.transform.position = startPosition1;
			}

			if (this.gameObject.CompareTag ("image2")) 
			{
				this.transform.position = startPosition1;
			}
		}

	}

	/*void OnBecameInvisible()
	{
		print(this.gameObject.tag);
		if (this.gameObject.CompareTag ("image1")) 
		{
			this.transform.position = startPosition1;
		}

		if (this.gameObject.CompareTag ("image2")) 
		{
			this.transform.position = startPosition2;
		}
	}*/

	public bool IsVisibleInCamera()
        {
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
            return GeometryUtility.TestPlanesAABB(planes, m1.bounds);
        }


}