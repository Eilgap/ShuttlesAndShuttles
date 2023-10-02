using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAmount : MonoBehaviour
{
    public int playerCount;
    public Text CountText;
    public Player player1 = new Player();
    public Player player2 = new Player();
    public Player player3 = new Player();
    public Player player4 = new Player();
    // Start is called before the first frame update
    void Start()
    {
        playerCount = 2;
        CountText.text = playerCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getPlayerCount()
    {
        return playerCount;
    }

    public void raisePlayerCount()
    {
        if(playerCount < 4)
        {
            playerCount++;
            CountText.text = playerCount.ToString();
        }
    }

    public void lowerPlayerCount()
    {
        if(playerCount > 2)
        {
            playerCount--;
            CountText.text = playerCount.ToString();
        }
    }

    public void continueButton()
    {
        PlayerPrefs.SetInt("PlayerAmount", playerCount);
        SceneManager.LoadScene("SelectCharacters");
        //For after the game works:
        //SceneManager.LoadScene("SelectCharacters");
    }

}