using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance { get; set; }
    public GameObject GameOver, MainGame;


    // Start is called before the first frame update
    void Start()
    {
        GameOver.SetActive(false);
    }

    public void ImpostorWin()
    {
        GameOver.SetActive(true);
    }
}
