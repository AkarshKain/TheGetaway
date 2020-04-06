using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour
{

    public GameObject panel;
    public string set;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void settings()
    {
        SceneManager.LoadScene(set);
    }

    public void openpanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

}
