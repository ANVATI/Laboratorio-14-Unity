using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerControlMen�: MonoBehaviour
{

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return)==true)
        {
            SceneManager.LoadScene("Level");
        }

    }
}
