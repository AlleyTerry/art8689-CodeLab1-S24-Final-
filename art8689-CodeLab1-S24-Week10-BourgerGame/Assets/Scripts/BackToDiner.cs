using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToDiner : MonoBehaviour
{
    public void BackToDinerButton()
    {
        SceneManager.LoadScene("LevelScene");
        ASCIILevelLoader.instance.newButton.SetActive(true);
        //Invoke("NewLevel", 2f );
    }

   
}
