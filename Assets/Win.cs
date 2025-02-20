using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class KeyPressExample : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Check if the "R" key was pressed
        {
            RunCode();
        }
    }

    void RunCode()
    {
        Debug.Log("R button pressed!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}