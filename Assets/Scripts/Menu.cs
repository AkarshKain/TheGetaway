using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string mainGame;
    public string set;

    public void StartGame()
    {
        SceneManager.LoadScene(mainGame);
    }
        

    public void Settings()
    {
      SceneManager.LoadScene(set);
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
