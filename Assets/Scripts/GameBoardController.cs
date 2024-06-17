using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameBoardController : MonoBehaviour
{
    public int playerNumber;
    public int playerId;
    public int spriteChoice;
    public float vectorX;
    public float vectorY;
    public int[] playPos = {1, 1, 1, 1};
    public GameObject play1;
    public GameObject play2;
    public GameObject play3;
    public GameObject play4;
    public Sprite Logan;
    public Sprite Ray;
    public Sprite Will;
    public Sprite Ethan;
    public Sprite Yusuf;
    public Sprite Zach;
    public Sprite Laura;
    public Sprite Paige;
    public Sprite Allie;
    public Sprite Koby;
    public Text turnText;
    public Text rollText;
    public int currentTurn;
    public Button rollButton;
    public Vector3 move;
    public bool moving;
    // Start is called before the first frame update
    
    void Start()
    {
        playerNumber = PlayerPrefs.GetInt("PlayerAmount");
        rollButton.onClick.AddListener(() => diceRoll());
        switch(playerNumber)
        {
            case 2:
                spriteChoice = PlayerPrefs.GetInt("Player1Sprite");
                setSprite(spriteChoice, 1);
                spriteChoice = PlayerPrefs.GetInt("Player2Sprite");
                setSprite(spriteChoice, 2);
                setPosition(1, 1);
                setPosition(1, 2);
                play3.SetActive(false);
                play4.SetActive(false);
                break;
            case 3:
                spriteChoice = PlayerPrefs.GetInt("Player1Sprite");
                setSprite(spriteChoice, 1);
                spriteChoice = PlayerPrefs.GetInt("Player2Sprite");
                setSprite(spriteChoice, 2);
                spriteChoice = PlayerPrefs.GetInt("Player3Sprite");
                setSprite(spriteChoice, 3);
                setPosition(1, 1);
                setPosition(1, 2);
                setPosition(1, 3);
                play4.SetActive(false);
                break;
            case 4:
                spriteChoice = PlayerPrefs.GetInt("Player1Sprite");
                setSprite(spriteChoice, 1);
                spriteChoice = PlayerPrefs.GetInt("Player2Sprite");
                setSprite(spriteChoice, 2);
                spriteChoice = PlayerPrefs.GetInt("Player3Sprite");
                setSprite(spriteChoice, 3);
                spriteChoice = PlayerPrefs.GetInt("Player4Sprite");
                setSprite(spriteChoice, 4);
                setPosition(1, 1);
                setPosition(1, 2);
                setPosition(1, 3);
                setPosition(1, 4);
                break;
        }
        currentTurn = 1;
    }

    // Update is called once per frame
    void Update()
    {
        turnText.text = "It is currently player " + currentTurn + "'s turn";
        /*move = new Vector3(xCoorOfPos(90), yCoorOfPos(90), 0);
        play1.transform.position = Vector3.MoveTowards(play1.transform.position, move, 15f * Time.deltaTime);*/
    }

    public void setPlayerActive(int c)
    {
        switch(c)
        {
            case 1:
                play1.SetActive(true);
                break;
            case 2:
                play2.SetActive(true);
                break;
            case 3:
                play3.SetActive(true);
                break;
            case 4:
                play4.SetActive(true);
                break;
        }
    }

    public void diceRoll()
    {
        System.Random r = new System.Random();
        int roll = r.Next(1, 7);
        rollText.text = "Roll: " + roll.ToString();
        switch(currentTurn)
        {
            case 1:
                playPos[0] += roll;
                setPosition(playPos[0], currentTurn);
                break;
            case 2:
                playPos[1] += roll;
                setPosition(playPos[1], currentTurn);
                break;
            case 3:
                playPos[2] += roll;
                setPosition(playPos[2], currentTurn);
                break;
            case 4:
                playPos[3] += roll;
                setPosition(playPos[3], currentTurn);
                break;
        }
        if(playPos[currentTurn - 1] >= 100)
        {
            Application.Quit();
        }

        currentTurn++;
        if(currentTurn > playerNumber)
        {
            currentTurn = currentTurn - playerNumber;
        }
    }

    public int getPlayerOrder()
    {
        return playerNumber;
    }

    public void setPosition(int space, int player)
    {
        vectorY = yCoorOfPos(space);
        vectorX = xCoorOfPos(space);
        switch(player)
        {
            case 1:
                play1.transform.position = new Vector3(vectorX, vectorY, 0);
                break;
            case 2:
                play2.transform.position = new Vector3(vectorX, vectorY, 0);
                break;
            case 3:
                play3.transform.position = new Vector3(vectorX, vectorY, 0);
                break;
            case 4:
                play4.transform.position = new Vector3(vectorX, vectorY, 0);
                break;
        }
    }

    public float xCoorOfPos(int space)
    {
        float xCoor = 0;
        int spaceOnRow = space % 10;
        int col = columnSpace(space);
        switch(spaceOnRow)
        {
            case 0:
                xCoor = 4.55f;
                break;
            case 1:
                xCoor = -4.55f;
                break;
            case 2:
                xCoor = -3.50f;
                break;
            case 3:
                xCoor = -2.5f;
                break;
            case 4:
                xCoor = -1.5f;
                break;
            case 5:
                xCoor = -000.5f;
                break;
            case 6:
                xCoor = .5f;
                break;
            case 7:
                xCoor = 1.5f;
                break;
            case 8:
                xCoor = 2.5f;
                break;
            case 9:
                xCoor = 3.5f;
                break;

        }
        if(col % 2 == 0)
        {
            xCoor = -xCoor;
        }
        return xCoor;
    }

    public int columnSpace(int s)
    {
        int spaceOnColumn = 0;
        if(s >= 1 && s <= 10)
        {
            spaceOnColumn = 1;
        }
        else if(s >= 11 && s <= 20)
        {
            spaceOnColumn = 2;
        }
        else if(s >= 21 && s <= 30)
        {
            spaceOnColumn = 3;
        }
        else if(s >= 31 && s <= 40)
        {
            spaceOnColumn = 4;
        }
        else if(s >= 41 && s <= 50)
        {
            spaceOnColumn = 5;
        }
        else if(s >= 51 && s <= 60)
        {
            spaceOnColumn = 6;
        }
        else if(s >= 61 && s <= 70)
        {
            spaceOnColumn = 7;
        }
        else if(s >= 71 && s <= 80)
        {
            spaceOnColumn = 8;
        }
        else if(s >= 81 && s <= 90)
        {
            spaceOnColumn = 9;
        }
        else if(s >= 91 && s <= 100)
        {
            spaceOnColumn = 10;
        }
        return spaceOnColumn;
    }

    public float yCoorOfPos(int space)
    {
        float yCoor = 0;
        int col = columnSpace(space);
        switch(col)
        {
            case 1:
                yCoor = -4.35f;
                break;
            case 2:
                yCoor = -3.5f;
                break;
            case 3:
                yCoor = -2.5f;
                break;
            case 4:
                yCoor = -1.5f;
                break;
            case 5:
                yCoor = -000.5f;
                break;
            case 6:
                yCoor = .5f;
                break;
            case 7:
                yCoor = 1.5f;
                break;
            case 8:
                yCoor = 2.5f;
                break;
            case 9:
                yCoor = 3.5f;
                break;
            case 10:
                yCoor = 4.35f;
                break;
            default:
                yCoor = -3;
                break;
        }
        return yCoor;
    }

    public void setSprite(int choice, int playerNumber)
    {
        SpriteRenderer spRen;
        Sprite spChoice = Logan;
        switch(choice)
        {
            case 1:
                spChoice = Logan;
                break;
            case 2:
                spChoice = Ray;
                break;
            case 3:
                spChoice = Will;
                break;
            case 4:
                spChoice = Ethan;
                break;
            case 5:
                spChoice = Yusuf;
                break;
            case 6:
                spChoice = Zach;
                break;
            case 7:
                spChoice = Laura;
                break;
            case 8:
                spChoice = Paige;
                break;
            case 9:
                spChoice = Allie;
                break;
            case 10:
                spChoice = Koby;
                break;
        }
        switch(playerNumber)
        {
            case 1:
                spRen = play1.GetComponent<SpriteRenderer>();
                spRen.sprite = spChoice;
                break;
            case 2:
                spRen = play2.GetComponent<SpriteRenderer>();
                spRen.sprite = spChoice;
                break;
            case 3:
                spRen = play3.GetComponent<SpriteRenderer>();
                spRen.sprite = spChoice;
                break;
            case 4:
                spRen = play4.GetComponent<SpriteRenderer>();
                spRen.sprite = spChoice;
                break;
        }
    }
}
