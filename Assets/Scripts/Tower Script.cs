using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TowerScript : MonoBehaviour
{
    public float moveSpeed, rangeValue, x, y, z, rotSpeed;
    //Acts as Settable Vectors
    public Quaternion rotation, eularAngles, currentRotation;
    public Vector3 currentEulerAngles;
    public Transform TargetA;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookRotation();
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeValue);
    }

    public void EnemyDetection()
    {
        float dist = Vector3.Distance(TargetA.position, transform.position);
        if (dist <= rangeValue)
        {
           Debug.Log("Amogus Detected");
        }
    }

    void LookRotation()
    {
        Vector3 relativepos = TargetA.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativepos, Vector3.up);
        transform.rotation = rotation;
        
    }
}
