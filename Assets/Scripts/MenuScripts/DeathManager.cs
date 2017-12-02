using UnityEngine;
using System.Collections;

public class DeathManager : MonoBehaviour {

	public void StartGame()
    {
        Application.LoadLevel("Platformer");
    }
    public void MenuGame()
    {
        Application.LoadLevel("StartMenu");
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartGame();
        }
        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("DeathMenu");
        }
    }
}
