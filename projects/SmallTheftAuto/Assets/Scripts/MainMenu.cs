using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void QuitGame()
    {
        Debug.Log("Would quit if was real bro!");
        Application.Quit();
    }
}
