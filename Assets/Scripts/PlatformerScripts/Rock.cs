using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
    public static int rockCount;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rockCount++;
            //PlatformController.score = PlatformController.score + 1;
            Destroy(gameObject);
        }
    }

}
