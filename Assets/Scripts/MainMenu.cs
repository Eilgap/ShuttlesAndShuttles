using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PlayerAmount", 0);
        PlayerPrefs.SetInt("Player1Sprite", 0);
        PlayerPrefs.SetInt("Player2Sprite", 0);
        PlayerPrefs.SetInt("Player3Sprite", 0);
        PlayerPrefs.SetInt("Player4Sprite", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("SelectPlayerAmount");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
