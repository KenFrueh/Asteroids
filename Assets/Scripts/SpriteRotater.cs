using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteRotater : MonoBehaviour
{
    private Transform tf;//Variable for the transform
    public float turnSpeed = 1.0f;//Variable for the rotation of the object
    public float movementSpeed = 1.0f;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Shoot()//Shooting function
    {
        throw new NotImplementedException();
    }
}
