using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 d = Vector3.zero;
        d.y += 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        Vector3 d = Vector3.zero;
        d.y += 1.0f;
        transform.Translate(d * speed * Time.deltaTime);
        if(transform.position.y >= 2500)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
