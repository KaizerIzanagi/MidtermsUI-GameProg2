using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyScript : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
        LookRotation();
    }

    void EnemyMove()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, GameController.Instance.player.position, step);
    }

    void LookRotation()
    {
        Vector3 relativepos = GameController.Instance.player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativepos, Vector3.up);
        transform.rotation = rotation;
    }
}
