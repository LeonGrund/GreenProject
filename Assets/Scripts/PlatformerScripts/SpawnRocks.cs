using UnityEngine;
using System.Collections;

public class SpawnRocks : MonoBehaviour {
   
    public Transform[] rockSpawns;
    public Transform[] kryptoniteSpawns;
    public Transform[] fuelSpawn;
    public Transform[] alienSpawn;
    public Transform[] batSpawn;

    public GameObject rock;
    public GameObject kryptonite;
    public GameObject fuel;
    public GameObject alien;
    public GameObject spacebat;

    // Use this for initialization
    void Start () {
        Spawn();
	}
	
    void Spawn()
    {
        for(int i = 0; i < rockSpawns.Length; i++)  // **we could have different sizes of arrays**
        {
            int rockFlip = Random.Range(0, 2);  // generates 0 or 1
            if(rockFlip > 0)    // 50% chance of spawning a rock at our spawning locations
            {
                Instantiate(rock, rockSpawns[i].position, Quaternion.identity);
            }
        }
        for(int i = 0; i < kryptoniteSpawns.Length; i++)
        {
            int krypFlip = Random.Range(0, 6); // generates 0,1,2,3,4,5
            if(krypFlip == 3)    // 15% chance to spawn a kryptonite
            {
                Instantiate(kryptonite, kryptoniteSpawns[i].position, Quaternion.identity);
            }
        }

        for(int i = 0; i < fuelSpawn.Length; i++)
        {
            int fuelFlip = Random.Range(0, 10);
            if(fuelFlip == 2 || fuelFlip == 7)
            {
                Instantiate(fuel, fuelSpawn[i].position, Quaternion.identity);
            }
        }

        for (int i = 0; i < alienSpawn.Length; i++)
        {
            int alienFlip = Random.Range(0, 10);  // generates 0 or 1
            if (alienFlip > 8) { 
                 Instantiate(alien, alienSpawn[i].position, Quaternion.identity);
            }
        }

        for (int i = 0; i < batSpawn.Length; i++)
        {
            int batFlip = Random.Range(0, 10);  // generates 0 or 1
            if (batFlip > 8)
            {
                Instantiate(spacebat, batSpawn[i].position, Quaternion.identity);
            }
        }
    }
	
}
