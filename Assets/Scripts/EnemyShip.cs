using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {//Adding to enemy list
        GameManager.instance.enemiesList.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Fly forward always
        //Adjust rotation every update with heatseeking behavior
    }
    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }
}
