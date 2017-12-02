using UnityEngine;
using System.Collections;

public class Fuel : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.CompareTag("Player"))
         {
            //PlatformController.extraJump++;
                Destroy(gameObject);
            }

    }
}
