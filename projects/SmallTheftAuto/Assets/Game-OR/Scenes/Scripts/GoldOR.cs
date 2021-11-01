using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldOR : MonoBehaviour
{
   
    void Start()
    {
        Debug.Log("Gold is alive");
        GameObject parent = new GameObject("GoldView");
        GameObject child = new GameObject("GoldViewChild");
        child.transform.SetParent(parent.transform);
        Text text = child.AddComponent<Text>();
        text.text = "This is a gold view.";
    }

    
    void Update()
    {
        
    }
    
    void OnDestroy()
    {
        Debug.Log("Gold is ded");
    }
}
