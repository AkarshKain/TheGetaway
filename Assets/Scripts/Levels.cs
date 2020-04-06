using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Levels : MonoBehaviour
{

    public string level1;
    public string level2;
    public string menu;

    public void StartLevel1()
    {
        SceneManager.LoadScene(level1);

    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(level2);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menu);

        }
    }

    
}
