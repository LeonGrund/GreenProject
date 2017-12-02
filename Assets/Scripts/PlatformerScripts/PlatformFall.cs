using UnityEngine;
using System.Collections;

public class PlatformFall : MonoBehaviour {
    public float fallDelay = 8f;
    public SpriteRenderer originalPlatform;
    public Sprite touchedPlatform1;
    public Sprite touchedPlatform2;
    public Sprite touchedPlatform3;
    private bool touched = false;

    private Rigidbody2D rb2d;

    /*
    makes the platforms fall when the platyer collides with them
    */

    // Use this for initialization
    void Awake() {
        rb2d = GetComponentInParent<Rigidbody2D>();
    }

    
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // call the fall function with the delay
            if (!touched)
            {
                originalPlatform.sprite = touchedPlatform1;

                //colorChange.color = Color.yellow;
                touched = true;
                Invoke("PlatformChange", fallDelay/2f);
            }

            Invoke("Fall", fallDelay);
        }
    }

    void PlatformChange()
    {
            originalPlatform.sprite = touchedPlatform2;
    }

    void Fall()
    {   // turn off gravity -> makes the platform fall
        originalPlatform.sprite = touchedPlatform3;
        rb2d.isKinematic = false;
       // originalPlatform.color = Color.red;   // color change
    }
}
