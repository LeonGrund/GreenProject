using UnityEngine;
using System.Collections;

public class SpriteChange : MonoBehaviour {
	public string OnType = "Player";
	public Sprite[] Images;
	public SpriteRenderer SRendere;
	public int startNum = 0;
	public float ResetDelay = 0f;

	void OnCollisionEnter2D (Collision2D other)
	{
			if (other.gameObject.CompareTag(OnType))
			{
				if (ResetDelay > 0f)
				{
					SRendere.sprite = Images[startNum+1];
					Invoke("Reset", ResetDelay);
				}
				else
				{
					// cycle through images
					SRendere.sprite = Images[startNum];
					startNum = (startNum + 1) % Images.Length;
				}
			}
	}

	void Reset ()
	{
		SRendere.sprite = Images[startNum];
	}
}
