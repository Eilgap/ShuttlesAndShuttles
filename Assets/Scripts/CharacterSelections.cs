using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelections : MonoBehaviour
{
    public PlayerAmount p;
    public int playerNumber;
    public int currentCount;
    // Start is called before the first frame update
    void Start()
    {
        p = FindObjectOfType<PlayerAmount>();
        playerNumber = p.getPlayerCount();
        currentCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void isSelectionDone()
    {
        if(currentCount > playerNumber)
        {
            SceneManager.LoadScene("GameBoard");
        }
    }
}
