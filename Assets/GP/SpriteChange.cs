using UnityEngine;
using System.Collections;

public class SpriteChange : MonoBehaviour {
	public string OnType = "Player";
	public Sprite[] Images;
	public SpriteRenderer SRendere;
	public int startNum = 0;

	void OnCollisionEnter2D (Collision2D other)
	{
			if (other.gameObject.CompareTag(OnType))
			{
				// cycle through images
				SRendere.sprite = Images[startNum];
				startNum = (startNum + 1) % Images.Length;
			}
	}
}
