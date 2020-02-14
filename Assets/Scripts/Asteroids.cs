using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float turnSpeed = 1.0f;
    public float movementSpeed = 1.0f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {//adding gameObject
        GameManager.instance.enemiesList.Add(this.gameObject);
        target = GameManager.instance.Player.transform;
        //Aim at the player at the start
        RotateTowards(target, true);
    }

    // Update is called once per frame
    void Update()
    {
        //Always moving
        MoveFoward();

    }
    public void OnCollisionEnter2D(Collision2D otherObject)//Colliding with an object 
    {
        if (otherObject.gameObject.name == "Parachute")
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);
        }
    }
    //Destroy the gameObject
    void Die()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
        Destroy(this.gameObject);
    }

    public void MoveFoward()
    {
        transform.Translate(new Vector3(0, movementSpeed * Time.deltaTime, 0));
    }
    protected void RotateTowards(Transform target, bool isInstant)
    {
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        float zAngle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90);
        if (!isInstant)
        {
            Quaternion targetLocation = Quaternion.Euler(0, 0, zAngle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetLocation, turnSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
        }
    }
}