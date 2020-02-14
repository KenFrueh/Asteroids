using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{//Lists of enemies of spawn and enemies
    public GameObject[] Enemies;
    public Transform[] spawnPoint;
    //Getting randon variables
    private int rand;
    private int randPosition;
    //Spawn between times
    public float startTimeBtwSpawns;
    public float timeBtwSpawns;
    // Start is called before the first frame update
    void Start()
    {//Spawning at start
        timeBtwSpawns = startTimeBtwSpawns;
    }

    // Update is called once per frame
    void Update()
    {//time between spawning
        if(timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, Enemies.Length);
            randPosition = Random.Range(0, spawnPoint.Length);
            Instantiate(Enemies[rand], spawnPoint[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }//Random spawning
        else
        {
            timeBtwSpawns -= Time.deltaTime; 
        }
    }
}
