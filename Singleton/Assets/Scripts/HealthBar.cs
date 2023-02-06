using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public static HealthBar Instance;
    
    //public int health = 100; - use this instance if I want health to reload when I go to next scene
    
    public TMP_Text healthB;
    private void Awake() 
    {         
        if (Instance == null) 
        { 
            DontDestroyOnLoad(gameObject);
            Instance = this;
        } 
        else 
        { 
            Destroy(gameObject);
        } 
    }

    private void Update()
    {
        healthB.text = "hp " + GameManager.Instance.health.ToString();
    }
}
