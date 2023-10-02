using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterSelections : MonoBehaviour
{
    public PlayerAmount p;
    public Text amountText;
    public Button loganButton;
    public Button rayButton;
    public Button willButton;
    public Button ethanButton;
    public Button yusufButton;
    public Button zachButton;
    public Button lauraButton;
    public Button paigeButton;
    public Button allieButton;
    public Button kobyButton;
    public int playerNumber;
    public int currentCount;

    // Start is called before the first frame update
    void Start()
    {
        loganButton.onClick.AddListener(() => spritePick(1));
        rayButton.onClick.AddListener(() => spritePick(2));
        willButton.onClick.AddListener(() => spritePick(3));
        ethanButton.onClick.AddListener(() => spritePick(4));
        yusufButton.onClick.AddListener(() => spritePick(5));
        zachButton.onClick.AddListener(() => spritePick(6));
        lauraButton.onClick.AddListener(() => spritePick(7));
        paigeButton.onClick.AddListener(() => spritePick(8));
        allieButton.onClick.AddListener(() => spritePick(9));
        kobyButton.onClick.AddListener(() => spritePick(10));
        playerNumber = PlayerPrefs.GetInt("PlayerAmount");
        currentCount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        amountText.text = "Player " + currentCount.ToString() + ", please select your character";
        if(playerNumber < currentCount)
        {
            SceneManager.LoadScene("GameBoard");
        }
    }

    public void spritePick(int choice)
    {
        switch(currentCount)
        {
            case 1:
                PlayerPrefs.SetInt("Player1Sprite", choice);
                break;
            case 2:
                PlayerPrefs.SetInt("Player2Sprite", choice);
                break;
            case 3:
                PlayerPrefs.SetInt("Player3Sprite", choice);
                break;
            case 4:
                PlayerPrefs.SetInt("Player4Sprite", choice);
                break;
        }
        currentCount++;
    }
}
