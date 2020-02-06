using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Leaving the player area and destroying attached object
    void OnTriggerExit2D(Collider2D Other)
    {
        Destroy(Other.gameObject);
        Debug.Log("Object has been destroyed");
    }
}
