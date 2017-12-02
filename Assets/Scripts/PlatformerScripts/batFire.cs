using UnityEngine;
using System.Timers;
using System.Collections;

public class batFire : MonoBehaviour
{
    public float shootDelay = 5f;
    public Transform FirePoint;
    public GameObject txn;

   // public float spitballDelay = (floaTime.fixedDeltaTime.ToString + 5f;

    //void Update()
    //{
        //System.Threading.Thread.Sleep(5000);
        //Task.Delay(2000).Wait();
        //if (Time.fixedTime.Equals(spitballDelay))
        // transform.Translate(Vector2.left * Time.deltaTime * 1f, Space.World);
        //if(15 == Random.Range(1,200))
        //{
        
            //spitballDelay = Time.fixedDeltaTime + 5f;
     //   }
    //}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("Attack", shootDelay);
        }

    }

    void Attack()
    {
        GameObject.Instantiate(txn, FirePoint.position, Quaternion.identity);
    }

    }
