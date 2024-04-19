using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ASCIILevelLoader : MonoBehaviour
{
    public GameObject newButton;
    private int currentLevel = 0;

    private GameObject level;

    public int CurrentLevel
    {
        get
        {
            return currentLevel;
        }

        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }

    private string FILE_PATH;

    public static ASCIILevelLoader instance;
    
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

        FILE_PATH = Application.dataPath + "/Levels/LevelNum.txt";

        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel()
    {
        //Destroys what ever level is currently present
        Destroy(level);
        //new level empty parent object to hold all the assets
        level = new GameObject("Level Objects");

        string[] lines = File.ReadAllLines(FILE_PATH.Replace("Num", currentLevel + ""));

        for (int yLevelPos = 0; yLevelPos < lines.Length; yLevelPos++)
        {
            //gets the line of characters in a string
            string line = lines[yLevelPos].ToUpper();
            //takes that line of characters and seperates each on into an array of characters
            char[] characters = line.ToCharArray();
            
            for (int xLevelPos = 0; xLevelPos < characters.Length; xLevelPos++)
            {
                char c = characters[xLevelPos];
                GameObject newObject = null;

                switch (c)
                {
                    case 'W': //checks for character 'W'
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/LevelLoader/Wall"));
                        break;
                    case 'P':
                        newObject = Instantiate((Resources.Load<GameObject>("Prefabs/LevelLoader/Player")));
                        Camera.main.transform.parent = newObject.transform;
                        Camera.main.transform.position = new Vector3(0, 0, -10);
                        break;
                    case 'C':
                        newObject = Instantiate(Resources.Load<GameObject>("Prefabs/LevelLoader/Customer"));
                        break;
                    default:
                        break;
                }

                if (newObject != null)
                {
                    newObject.transform.parent = level.transform;
                    newObject.transform.position = new Vector2(xLevelPos, -yLevelPos);
                }
            }
        }
    }
    public void NewLevel()
    {
        Debug.Log("this is being loaded");
        CurrentLevel++;
        
    }
}
