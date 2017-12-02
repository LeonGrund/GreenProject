using UnityEngine;
using System.Collections;

public class Kryptonite : MonoBehaviour {
    public static int krypCount;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            krypCount++;
            //PlatformController.score = PlatformController.score + 10;
            Destroy(gameObject);
        }
    }
}
