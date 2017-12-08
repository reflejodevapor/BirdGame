using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public Text scoretext;
	public Text bulletstext;
	public Image hearts;
	public int score = 0;
	public int health = 3;
	public int bullets = 5;


	// Use this for initialization
	void Start () 
	{
		bulletstext.text = bullets.ToString ();
		scoretext.text = score.ToString ();


		InvokeRepeating ("ReloadBullets", 2.0f, 1.5f);
		InvokeRepeating ("ReloadHearts", 2.0f, 8.0f);
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		bulletstext.text = bullets.ToString ();
		scoretext.text = score.ToString ();
		hearts.fillAmount = (health * 0.333f);

	}

	void ReloadBullets()
	{
		if (bullets >= 0 && bullets < 5) 
		{
			bullets += 1;
		}

	}

	void ReloadHearts()
	{
		if (health > 0 && health < 3) 
		{
			health += 1;
		}

	}
}
