using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//adding gameObject
        GameManager.instance.enemiesList.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Destroy the gameObject
    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }
}
