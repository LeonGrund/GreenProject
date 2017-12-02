using UnityEngine;
using System.Collections;

public class farmerDialog : MonoBehaviour {

	public Sprite farmer0;
	public Sprite farmer1;
	public Sprite farmer2;

	public float dialogDelay = 2f;
	public float resetDelay = 8f;
	private SpriteRenderer SRenderer;
	private bool flag = true;

	// Use this for initialization
	void Start () {
		SRenderer = GetComponent<SpriteRenderer>();
		SRenderer.sprite = farmer0;
	}

	void OnCollisionEnter2D (Collision2D other)
	{
			if (other.gameObject.CompareTag("Player") && flag)
			{
					flag = false;						// cannnot reactivate farmer, player hast to wait
					Invoke("Activate", 0f);
			}
	}

	void Activate()
	{
		SRenderer.sprite = farmer1;
		Invoke("Dialog", dialogDelay);
	}

	void Dialog()
	{
		SRenderer.sprite = farmer2;
		Invoke("Reset", resetDelay);
	}

	void Reset()
	{
		SRenderer.sprite = farmer0;
		flag = true;
	}
}
