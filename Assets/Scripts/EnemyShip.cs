using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float turnSpeed = 1.0f;//Variable for the rotation of the object
    public float movementSpeed = 1.0f;//Moving forward 
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //Adding to enemy list
        GameManager.instance.enemiesList.Add(this.gameObject);
    }
    //Updating movement
    void Update()
    {
        MoveFoward();
        RotateTowards(target, false);
    }
    //Destroying gameObject
    public void Die()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
        Destroy(this.gameObject);
    }
    //Always moving forward
    public void MoveFoward()
    {
        transform.Translate(new Vector3(0, movementSpeed * Time.deltaTime, 0));
    }
    // Adjust rotation every update with heatseeking behavior
    protected void RotateTowards(Transform target, bool isInstant)
    {//Tracking position of player
        Vector3 direction = target.position - transform.position;
        direction.Normalize();
        float zAngle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90);
        if (!isInstant)
        {
            Quaternion targetLocation = Quaternion.Euler(0, 0, zAngle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetLocation, turnSpeed * Time.deltaTime);
        }
        else
        {//Editing rotation based on location
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
        }
    }

}
