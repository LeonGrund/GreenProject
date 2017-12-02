using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
    public float LiveTime = 5f;
    public float Speed = 1f;
    private bool bulletDirection = PlatformController.facingRight; // True is right, False is left
    // Use this for initialization
    void Awake ()
    {
        Destroy(transform.gameObject, LiveTime);
	   }

    // Update is called once per frame
      void Update()
      {
          if (bulletDirection)
          {
              transform.Translate(Vector2.right * Time.deltaTime * Speed, Space.World);
          }
          else
          {
              transform.Translate(Vector2.left * Time.deltaTime * Speed, Space.World);
          }
      }

      void OnTriggerEnter2D(Collider2D other)
      {
          Destroy(transform.gameObject);
      }
}
