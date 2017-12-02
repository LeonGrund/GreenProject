using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {

    public int maxPlatformsLVL1 = 20;   // default max of 20 platforms will spawn
    public int maxPlatformsLVL2 = 10;
    public int maxPlatformsLVL3 = 10;

    public GameObject platform;
    public GameObject miniPlatform;
    public GameObject endPlatform;

    // x and y for ground
    public float horizontalMin = 6.5f;  // max distance between the platform
    public float horizontalMax = 14f;   // so the player can jump on it
    public float verticalMin = -6f;     // the next platform will spawn 6 or -6 above or below the last one
    public float verticalMax = 6f;
    // x and y added to ground for miniGround
    public float miniHorizontalMin = 6f;
    public float miniHorizontalMax = 10f;
    public float miniVerticalMin = 12f;
    public float miniVerticalMax = 18f;
    // x and y for lvl2 ground
    public float horizontalMinLvl2 = 10f;
    public float horizontalMaxLvl2 = 17f;
    public float verticalMinLvl2 = -8f;
    public float verticalMaxLvl2 = 10f;
    // x and y added to ground for lvl2 miniGround
    public float miniHorizontalMinLvl2 = 6f;
    public float miniHorizontalMaxLvl2 = 10f;
    public float miniVerticalMinLvl2 = 12f;
    public float miniVerticalMaxLvl2 = 18f;
    // x and y for lvl3 ground
    public float horizontalMinLvl3 = 10f;
    public float horizontalMaxLvl3 = 17f;
    public float verticalMinLvl3 = -8f;
    public float verticalMaxLvl3 = 10f;
    // x and y for lvl3 miniGround
    public float miniHorizontalMinLvl3 = 6f;
    public float miniHorizontalMaxLvl3 = 10f;
    public float miniVerticalMinLvl3 = -8f;
    public float miniVerticalMaxLvl3 = 10f;

    private Vector2 originPosition;
  
	void Start () {

        originPosition = new Vector2(21.48f,-2.42f); //the first platform will spawn where the player spawn
        Spawn();
        Spawn2();
        Spawn3();
        Spawn4();
        Instantiate(endPlatform, (originPosition + new Vector2(15, 0)), Quaternion.identity);
	}
	
	void Spawn()
    {
	    for(int i = 0; i <maxPlatformsLVL1; i++)
        {   // keep spawning platforms until maxPlatforms in our min and max ranges
            float x = Random.Range(horizontalMin, horizontalMax);
            float y = Random.Range(verticalMin, verticalMax);

            Vector2 randomPosition = originPosition + new Vector2(x, y); // conputes position of ground

            Instantiate(platform, randomPosition, Quaternion.identity); // creates the ground
           

            float miniX = Random.Range(miniHorizontalMin, miniHorizontalMax);
            float miniY = Random.Range(miniVerticalMin, miniVerticalMax);
            // computes the position of miniGround
            Vector2 randomMiniPosition = randomPosition + new Vector2(miniX,miniY); // add miniX and miniY to ground position

            Instantiate(miniPlatform, randomMiniPosition, Quaternion.identity); // creates the miniGround above ground

            originPosition = randomPosition; // next iteration we add the new spawning postion to the last one and then start from there
        }    
	}
    void Spawn2()
    {
        for(int i = 0; i < maxPlatformsLVL2; i++)
        {
            float x = Random.Range(horizontalMinLvl2, horizontalMaxLvl2);
            float y = Random.Range(verticalMinLvl2, verticalMaxLvl2);

            Vector2 randomPositionLvl2 = originPosition + new Vector2(x, y);

            Instantiate(platform, randomPositionLvl2, Quaternion.identity);


            float miniX = Random.Range(miniHorizontalMinLvl2, miniHorizontalMaxLvl2);
            float miniY = Random.Range(miniVerticalMinLvl2, miniVerticalMaxLvl2);

            int miniSpawn = Random.Range(0, 2);
            if(miniSpawn == 1)
            {
                Vector2 randomMiniPositionLvl2 = randomPositionLvl2 + new Vector2(miniX, miniY);
                Instantiate(miniPlatform, randomMiniPositionLvl2, Quaternion.identity);
            }

            originPosition = randomPositionLvl2;
        }
    }

    void Spawn3()
    {

        for (int i = 0; i < maxPlatformsLVL3; i++)
        {   // keep spawning platforms until maxPlatforms in our min and max ranges
            int spawnRanPlatform = Random.Range(0, 2);

            if (spawnRanPlatform == 0)
            {

                float x = Random.Range(horizontalMinLvl3, horizontalMaxLvl3);
                float y = Random.Range(verticalMinLvl3, verticalMaxLvl3);

                Vector2 randomPositionLvl3 = originPosition + new Vector2(x, y); // conputes position of ground

                Instantiate(platform, randomPositionLvl3, Quaternion.identity); // creates the ground
                originPosition = randomPositionLvl3;
            }
            else
            {
                float miniX = Random.Range(miniHorizontalMinLvl3, miniHorizontalMaxLvl3);
                float miniY = Random.Range(miniVerticalMinLvl3, miniVerticalMaxLvl3);
                // computes the position of miniGround
                Vector2 randomMiniPositionLvl3 = originPosition + new Vector2(miniX, miniY); // add miniX and miniY to ground position

                Instantiate(miniPlatform, randomMiniPositionLvl3, Quaternion.identity); // creates the miniGround above ground

                originPosition = randomMiniPositionLvl3; // next iteration we add the new spawning postion to the last one and then start from there
            }
        }
    }
    void Spawn4()
    {

        for (int i = 0; i < maxPlatformsLVL3; i++)
        {   // keep spawning platforms until maxPlatforms in our min and max ranges
            int spawnRanPlatform = Random.Range(0, 3);

            if (spawnRanPlatform == 1)
            {

                float x = Random.Range(horizontalMinLvl3, horizontalMaxLvl3);
                float y = Random.Range(verticalMinLvl3, verticalMaxLvl3);

                Vector2 randomPositionLvl3 = originPosition + new Vector2(x, y); // conputes position of ground

                Instantiate(platform, randomPositionLvl3, Quaternion.identity); // creates the ground
                originPosition = randomPositionLvl3;

                int miniSpawn = Random.Range(0, 3);
                if (miniSpawn == 1)
                {
                    float miniAboveX = Random.Range(miniHorizontalMinLvl2, miniHorizontalMaxLvl2);
                    float miniAboveY = Random.Range(miniVerticalMinLvl2, miniVerticalMaxLvl2);

                    Vector2 randomMiniPositionAbove = randomPositionLvl3 + new Vector2(miniAboveX, miniAboveY +4);
                    Instantiate(miniPlatform, randomMiniPositionAbove, Quaternion.identity);
                }
            }
            else
            {
                float miniX = Random.Range(miniHorizontalMinLvl3, miniHorizontalMaxLvl3);
                float miniY = Random.Range(miniVerticalMinLvl3, miniVerticalMaxLvl3);
                // computes the position of miniGround
                Vector2 randomMiniPositionLvl3 = originPosition + new Vector2(miniX, miniY); // add miniX and miniY to ground position

                Instantiate(miniPlatform, randomMiniPositionLvl3, Quaternion.identity); // creates the miniGround above ground

                originPosition = randomMiniPositionLvl3; // next iteration we add the new spawning postion to the last one and then start from there

                int miniSpawn = Random.Range(0, 3);
                if (miniSpawn == 1)
                {
                    float miniAboveX = Random.Range(miniHorizontalMinLvl2, miniHorizontalMaxLvl2);
                    float miniAboveY = Random.Range(miniVerticalMinLvl2, miniVerticalMaxLvl2);

                    Vector2 randomMiniPositionAbove = randomMiniPositionLvl3 + new Vector2(miniAboveX, miniAboveY+4);
                    Instantiate(miniPlatform, randomMiniPositionAbove, Quaternion.identity);
                }
            }
        }
    }
}
