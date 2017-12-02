using UnityEngine;
using System.Collections;

public class t : MonoBehaviour {
	public float time = 2f;

	void Start ()
	{
		Destroy(transform.gameObject, time);
	}

}
