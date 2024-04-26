using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToDiner : MonoBehaviour
{
    public void BackToDinerButton()
    {
        SceneManager.LoadScene("LevelScene");
        ASCIILevelLoader.instance.CurrentLevel++;
        //Invoke("NewLevel", 2f );
    }

    public void NewLevel()
    {
        Debug.Log("this was loaded");
        ASCIILevelLoader.instance.CurrentLevel++;
        
    }

   
}
