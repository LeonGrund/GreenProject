using UnityEngine;
using System.Collections;

public class keySparkle : MonoBehaviour {

	public Sprite key1;
	public Sprite key2;
	public Sprite key3;
	public Sprite key4;
	public SpriteRenderer SRenderer;
	public float delay = 0.5f;

	// Use this for initialization
	void Start () {
		Invoke("k1", delay);
	}

	void OnCollisionEnter2D (Collision2D other)
	{
			if (other.gameObject.CompareTag("Player"))
			{
				Destroy(transform.gameObject, 0f);
			}
	}
	void k1 ()
	{
		SRenderer.sprite = key1;
		Invoke("k2", delay);
	}

	void k2 ()
	{
		SRenderer.sprite = key2;
		Invoke("k3", delay);
	}

	void k3 ()
	{
		SRenderer.sprite = key3;
		Invoke("k4", delay);
	}

	void k4 ()
	{
		SRenderer.sprite = key4;
		Invoke("k1", delay);
	}
}
