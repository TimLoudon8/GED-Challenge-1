using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTarget : MonoBehaviour
{
    Health health;

    float timer;
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            health.RemoveHealth(1);
            Destroy(gameObject);
        }
    }

    public void StartTimer()
    {
        timer += Time.deltaTime;

        if(timer >= 5)
        {
            Destroy(gameObject);
        }
    }
}
