using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerControl : MonoBehaviour
{
    public MusicControl musicControl;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            musicControl.PlayMusic(1);
        }
        else if (Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.W) == true)
        {
            musicControl.PlayMusic(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape)==true)
        {
            SceneManager.LoadScene("Menú");
        }

    }
}
