﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        
        
        if(collider.gameObject.tag == "Player")
        {
            print("Item pego");
            Destroy(gameObject);
        }
        
    }
}
