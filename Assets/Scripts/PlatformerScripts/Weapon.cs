using UnityEngine;
using System.Collections;

public abstract class Weapon : MonoBehaviour {

    public Transform FirePoint;
    public GameObject bulletRight;
    public GameObject bulletLeft;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {

            if (PlatformController.facingRight)
            {
                GameObject.Instantiate(bulletRight, FirePoint.position, Quaternion.identity);
            }
            else
            {
                GameObject.Instantiate(bulletLeft, FirePoint.position, Quaternion.identity);
            }
        }
    }
}
