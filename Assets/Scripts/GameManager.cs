using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   //Manager when game start
    public static GameManager instance;
    //Track score
    public int score = 0;
    public int lives = 3;
    //Track pause boolean
    public bool IsPaused = false;
    //Getting player
    public GameObject playerPrefab;
    public GameObject Player;
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
    public void Respawn()//Respawning the player
    {
        Instantiate(playerPrefab);
    }
}
