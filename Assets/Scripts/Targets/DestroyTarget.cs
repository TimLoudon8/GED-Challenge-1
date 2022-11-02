using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
