using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    BadTarget badTarget;

    float xPos;
    float yPos = 0.75f;
    float zPos;
    public float spawnTimer;
    float timer;
    float goodOrBad;

    public GameObject goodPrefab;
    public GameObject badPrefab;

    GameObject temp;

    Subject subject = new Subject();

    // Start is called before the first frame update
    void Start()
    {
        Destroyed destroyed = new Destroyed(this.gameObject);
        subject.AddObserver(destroyed);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        goodOrBad = Random.Range(1, 3);

        if (goodOrBad == 1)
        {
            if (timer >= spawnTimer)
            {
                timer -= spawnTimer;
                xPos = Random.Range(10, -10);
                zPos = Random.Range(3, -3);
                temp = Instantiate(goodPrefab, new Vector3(xPos, yPos, zPos), transform.rotation);
                temp.gameObject.tag = "Target";
            }
        }
        else if (goodOrBad >= 2)
        {
            if (timer >= spawnTimer)
            {
                timer -= spawnTimer;
                xPos = Random.Range(10, -10);
                zPos = Random.Range(3, -3);
                temp = Instantiate(badPrefab, new Vector3(xPos, yPos, zPos), transform.rotation);
                temp.gameObject.tag = "Target";
                badTarget.StartTimer();
            }
        }
    }
}
