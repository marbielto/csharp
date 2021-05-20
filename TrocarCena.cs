﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{	
	public int cena;
    
    void OnTriggerEnter (Collider hit){
    	if(hit.tag == "Player"){
    		SceneManager.LoadScene(cena);
    	}
    }
}
