using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class SpinningCube : MonoBehaviour
{
    public float x, y, z, rotSpeed;
    //Acts as Settable Vectors
    public Quaternion rotation, eularAngles, currentRotation;
    public Vector3 currentEulerAngles;
    public ColorBullet colors;
    public GameObject redCube, blackCube, yellowCube;

    private void Start()
    {
        colors = ColorBullet.red;
    }

    void Update()
    {
        Rotation();

        switch (colors)
        {
            case ColorBullet.red:
                redCube.SetActive(true);
                blackCube.SetActive(false);
                yellowCube.SetActive(false);
                break; 
            case ColorBullet.black:
                redCube.SetActive(false);
                blackCube.SetActive(true);
                yellowCube.SetActive(false);
                break; 
            case ColorBullet.yellow:
                redCube.SetActive(false);
                blackCube.SetActive(false);
                yellowCube.SetActive(true);
                break;
        }
    }

    public void Rotation()
    {
        x = 1;
        y = 0;
        z = 1;

        //Modify the vector 3 based on input multiplied by time and rotSpeed
        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotSpeed;
        //Moving the value of vector 3 into Quaternion.Angle
        currentRotation.eulerAngles = currentEulerAngles;
        //Rotates the game Game Object based on the Quaternion.Angle
        transform.rotation = currentRotation;
    } 


}
