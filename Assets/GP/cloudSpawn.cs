using UnityEngine;
using System.Collections;

public class cloudSpawn : MonoBehaviour {

	public Sprite button1;
	public Sprite button2;
	public SpriteRenderer SRenderer = null;
	public float delay = 0.5f;
	public GameObject cloud;
	public Transform spawn;
	private bool flag = true;

	// Use this for initialization
	void Start () {
		SRenderer.sprite = button1;
	}

	void OnCollisionEnter2D (Collision2D other)
	{
			if (other.gameObject.CompareTag("Player") && flag)
			{
				flag = false;
				SRenderer.sprite = button2;
				Instantiate(cloud, spawn.position, Quaternion.identity);
				Invoke("Reset", delay);
			}
	}

	void Reset ()
	{
		SRenderer.sprite = button1;
		flag = true;
	}

}
