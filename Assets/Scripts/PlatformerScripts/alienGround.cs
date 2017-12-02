using UnityEngine;
using System.Collections;

public class alienGround : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            PlatformController.jump = true;

        }
    }
}
