using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//adding gameObject
        GameManager.instance.enemiesList.Add(this.gameObject);
        //Aim at the player at the start
    }

    // Update is called once per frame
    void Update()
    {
        //Always moving
    }
    public void OnCollisionEnter2D(Collision2D otherObject)//Colliding with an object 
    {
        if (otherObject.gameObject == GameManager.instance.parachutePrefab)
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);

        }
    }
    //Destroy the gameObject
    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }
}
