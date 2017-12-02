using UnityEngine;
using System.Collections;

public class bat : MonoBehaviour {

    public float fallDelay = 3f;
    private bool touched = false;
    public int HP = 1;
    private Rigidbody2D rb2d;
    public float LiveTime = 1f;
    public bool deadly = true;

    // private Color alphaColor;
    // private float timeToFade = 1.0f;
    /*
    makes the platforms fall when the platyer collides with them
    */

    void Awake()
    {
        rb2d = GetComponentInParent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            if (HP == 0)
            {
                //alphaColor = transform.gameObject.GetComponent<SpriteRenderer>().material.color;
                //alphaColor.a = 0;
                deadly = false;
                Fall();
            }
            else
            {
                HP -= 1;
            }
        }

        if (other.gameObject.CompareTag("Player") && deadly)
        {
            Application.LoadLevel("DeathMenu");
        }
        if (other.gameObject.CompareTag("ground"))
        {
            deadly = false;
            Fall();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            deadly = false;
            Fall();
        }
    }

    void PlatformChange()
    {
        //originalPlatform.sprite = touchedPlatform2;
    }

    void Fall()
    {   // turn off gravity -> makes the platform fall
        // originalPlatform.sprite = touchedPlatform3;
        rb2d.isKinematic = false;
        // originalPlatform.color = Color.red;   // color change
        Destroy(transform.gameObject, LiveTime);
        // transform.gameObject.GetComponent<SpriteRenderer>().material.color = Color.Lerp(transform.gameObject.GetComponent<SpriteRenderer>().material.color, alphaColor, timeToFade * Time.deltaTime);
    }

}
