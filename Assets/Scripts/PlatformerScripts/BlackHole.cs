using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel("Platformer");
          //  Destroy(gameObject);
        }

    }
}
