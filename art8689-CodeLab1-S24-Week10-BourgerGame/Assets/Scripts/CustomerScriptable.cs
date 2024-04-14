using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu (fileName = "New Customer", 
                  menuName = "New Customer", 
                  order = 0)]
public class CustomerScriptable : ScriptableObject
{
    public static CustomerScriptable instance;
    //[SerializeField]
    public Dictionary<string, int> customerburger1 = new Dictionary<string, int>();
    
    

    public void customerOrder()
    {
        customerburger1.Add("bun",Random.Range(1,4)); 
        customerburger1.Add("meat",Random.Range(1,4));
        customerburger1.Add("cheese",Random.Range(1,4));
        customerburger1.Add("lettuce", Random.Range(1,4));
       
    }
}
