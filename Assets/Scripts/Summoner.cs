using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject enemy;
    public float interval, baseInterval;

    void Start()
    {
        baseInterval = Random.Range(5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        interval -= Time.deltaTime;

        if (interval <= 0)
            {
                Spawn();
            }
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);

        interval = baseInterval;
    }
}
