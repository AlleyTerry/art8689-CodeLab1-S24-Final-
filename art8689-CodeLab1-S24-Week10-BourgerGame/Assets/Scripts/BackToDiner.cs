using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToDiner : MonoBehaviour
{
    public void BackToDinerButton()
    {
        GameManager.instance.IncreaseLevel();
        SceneManager.LoadScene("LevelScene");
        
        //Invoke("NewLevel", 2f );
    }
   
}
