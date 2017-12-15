using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Scrollingtext : MonoBehaviour 
{
	public Image mamada;
	public Sprite[] images;
	public float timer = 0;
	public float timermax = 0;

	void Update()
	{
		timer += Time.deltaTime;

		if (timer == 0)
			mamada.sprite = images [0];
		if (timer > 5 && (mamada.sprite == images [0]))
			mamada.sprite = images [1];
		if (timer > 10 && (mamada.sprite == images [1]))
			mamada.sprite = images [2];

		if (timer > 15 && (mamada.sprite == images [2]))
			SceneManager.LoadScene (0);

	}

	
}
