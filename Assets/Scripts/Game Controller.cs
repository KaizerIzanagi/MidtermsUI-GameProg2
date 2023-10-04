using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
