using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerAmount p;
    public int playerNumber;
    public int playerId;
    public int spriteChoice;
    public SpriteRenderer spriteRenderer;
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
    // Start is called before the first frame update
    
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setLocation(int x, int y, int space)
    {

    }

    public void getLocation()
    {

    }

    public void setPlayerOrder(int whichPlayer)
    {
        playerNumber = whichPlayer;
    }

    public int getPlayerOrder()
    {
        return playerNumber;
    }

    public void setSprite(int choice)
    {
        switch(choice)
        {
            case 1:
                spriteRenderer.sprite = Logan;
                break;
            case 2:
                spriteRenderer.sprite = Ray;
                break;
            case 3:
                spriteRenderer.sprite = Will;
                break;
            case 4:
                spriteRenderer.sprite = Ethan;
                break;
            case 5:
                spriteRenderer.sprite = Yusuf;
                break;
            case 6:
                spriteRenderer.sprite = Zach;
                break;
            case 7:
                spriteRenderer.sprite = Laura;
                break;
            case 8:
                spriteRenderer.sprite = Paige;
                break;
            case 9:
                spriteRenderer.sprite = Allie;
                break;
            case 10:
                spriteRenderer.sprite = Koby;
                break;
        }
    }
}
