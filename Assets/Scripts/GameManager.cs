using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{       //Getting player
    public GameObject playerPrefab;
    public GameObject Player;
    public GameObject parachutePrefab;
    public GameObject EnemyPrefab;
    //Manager when game start
    public static GameManager instance;
    //Track score
    public int score = 0;
    public int lives = 3;
    //Track pause boolean
    public bool IsPaused = false;
    public GameObject[] enemyPrefab;
    //List of enemies in scene
    public List<GameObject> enemiesList = new List<GameObject>();
    public void Awake()
    {
        if (instance == null)
        {
            instance = this; //Shows THIS of class in int variable
        }
        else
        {
            Destroy(this.gameObject); //Destroy Game manager attached to component
            Debug.LogError("Error: Tried to make second Game Manager");
        }
      
    }

    private void Update()
    {//Quiting application
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }//Respawning player on key press
        if (Input.GetKeyDown(KeyCode.P))
        {
            // if (Player == null)
            //{
            // Respawn();
            //}
            //Instantiate(parachutePrefab);
        }

    }
    public void Respawn()//Respawning the player
    {
        Player = Instantiate(playerPrefab);
    }
}
