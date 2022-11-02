using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text healthDisplay;
    public int health = 5;

    public void RemoveHealth(int value)
    {
        health -= value;
        Debug.Log(health);
    }

    public void Update()
    {
        healthDisplay.text = "Health: " + health.ToString();
    }
}
