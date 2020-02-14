﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform tf;//Variable for the transform
    public float turnSpeed = 1.0f;//Variable for the rotation of the object
    public float movementSpeed = 1.0f;
    public GameObject bulletPrefab;
    public Transform FirePoint;
    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>(); //Load transform into the variable
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))//Move player forward
        {
            tf.position += tf.up * movementSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))//Rotate to the right
        {
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//Rotate to the left
        {
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))//Shooting bullet gameObject
        {
            Shoot();
        }
    }

    public void Shoot()//Shooting function
    {
        Instantiate(original:bulletPrefab, FirePoint.position, FirePoint.rotation);
    }
    public void OnCollisionEnter2D(Collision2D otherObject)//Colliding with an object 
    {
        if (otherObject.gameObject.tag == "Enemy")
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
        }
    }
    public void OnCollisionExit2D(Collision2D otherObject)//Leaving the object collision
    {
        Debug.Log("The player died, so left the collision");
    }
    //destroying player function
    void  OnDestroy()
    {
        //Losing a life on destroy
        GameManager.instance.lives -= 1;
        if (GameManager.instance.lives > 0)
        {
            GameManager.instance.Respawn();
        }
        else
        {//Display Game over
            Debug.Log("Game Over");
        }
    }

}
