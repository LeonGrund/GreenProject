using UnityEngine;
using System.Collections;

public class SpitballFall : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
			if (other.gameObject.CompareTag("Bullet"))
			{
					Destroy(transform.gameObject);
			}

			if (other.gameObject.CompareTag("Player"))
			{
					Application.LoadLevel("DeathMenu");
			}
	}
	
}
