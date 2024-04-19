using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        { 
            //ASCIILevelLoader.instance.CurrentLevel++;
            Debug.Log("level was loaded");
            SceneManager.LoadScene("BurgerScene");
            
        }
    }
}
