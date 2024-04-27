using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60;

    public TextMeshProUGUI timerText;
    public TextMeshProUGUI barkText;

    public static GameManager instance;

    public List<String> barkList = new List<string>();

    public int barkNumber;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        barkList.Add("NOW");
        barkList.Add("GIMME MY FOOD");
        barkList.Add("IM HUNGRY");
        barkList.Add("1");
        barkList.Add("2");
        Invoke("ProgressDialoge", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = MathF.Floor(timer ) + "";
    }

    private void ProgressDialoge()
    {
        barkNumber++;
        barkText.text = barkList[barkNumber % barkList.Count];
        
        Invoke("ProgressDialoge", 1f);
        
    }

    public void IncreaseLevel()
    {
        Invoke("LoadLevel",1);
    }

    private void LoadLevel()
    {
        ASCIILevelLoader.instance.CurrentLevel++;
    }
}
