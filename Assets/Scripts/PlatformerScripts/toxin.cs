using UnityEngine;
using System.Collections;

public class toxin : MonoBehaviour {

    public float LiveTime = 10f;
    public float Speed = 1f;
    private int HP = 0;

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

    // Use this for initialization
  //  void Awake()
    //{
    //    Destroy(transform.gameObject, LiveTime);
    //}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed, Space.World);
    }

  }
