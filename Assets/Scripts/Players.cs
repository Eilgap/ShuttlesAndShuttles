using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public PlayerAmount p;
    public int playerNumber;
    // Start is called before the first frame update
    void Start()
    {
        p = FindObjectOfType<PlayerAmount>();
        playerNumber = p.getPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
