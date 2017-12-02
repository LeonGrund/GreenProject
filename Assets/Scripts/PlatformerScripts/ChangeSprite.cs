using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour {
    public Sprite groundSprite;
    public Sprite airSprite;
    public Sprite move1;
    public Sprite move2;
    public Sprite move3;
    public float delay1 = 1f;
    public float delay2 = 1f;
    public float delay3 = 1f;
    private SpriteRenderer SRenderer;
    public Transform groundCheck; // check if player is on the ground
    private bool flag = true;
    private float currentX = 0f;
    private float tempX = 0f;

    // Use this for initialization
    void Start ()
    {

        SRenderer = GetComponent<SpriteRenderer>();
        groundCheck = GetComponentInParent<Transform>();
        currentX = Mathf.Abs(groundCheck.position.x);
        if( SRenderer.sprite == null)
        {
            SRenderer.sprite = groundSprite;
        }
	}

	// Update is called once per frame
	void Update ()
  {

    tempX = Mathf.Abs(groundCheck.position.x);
  //  print( "+++++++++++");
    //print (currentX - tempX);
    //print (tempX);

    if((currentX - tempX) > .2f)
    {
      currentX = Mathf.Abs(groundCheck.position.x);
      if(flag)
      {
        SRenderer.sprite = move1;
        flag = false;
      }
      else
      {
        SRenderer.sprite = move2;
        flag = true;
      }
    }


       if(PlatformController.grounded)
       {
            SRenderer.sprite = groundSprite;
       }
      else
       {
            SRenderer.sprite = airSprite;
       }
	}



  void change1()
  {
      SRenderer.sprite = move1;
      Invoke("change2",delay2);
  }

  void change2()
  {
      SRenderer.sprite = move2;
  }
}
