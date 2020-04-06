using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public GameObject Char1;
    public GameObject Char2;

    public int p1life;
    public int p2life;

    public GameObject p1won;
    public GameObject p2won;
    public GameObject[] p1heart;
    public GameObject[] p2heart;

    public GameObject checkPoint;
    private Char_Behavior Character;

    public AudioSource Hurt;

    public string menu;



    // Start is called before the first frame update
    void Start()
    {
        Character = FindObjectOfType<Char_Behavior>();

    }

    // Update is called once per frame
    void Update()
    {
        if (p1life <= 0)
        {
            Char1.SetActive(false);
            p1won.SetActive(true);


        }

        if (p2life <= 0)
        {
            Char2.SetActive(false);
            p2won.SetActive(true);


        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(menu);

        }
    }

    public void hurtp1()
    {
        p1life -= 1;
        for (int i = 0; i < p1heart.Length; i++)
        {
            if (p1life > i)
            {
                p1heart[i].SetActive(true);
            }
            else { p1heart[i].SetActive(false);
            }

Hurt.Play();
        }  

    }

    public void hurtp2()
    {
        p2life -= 1;
        for (int i = 0; i < p1heart.Length; i++)
        {
            if (p2life > i)
            {
                p2heart[i].SetActive(true);
            }
            else
            {
                p2heart[i].SetActive(false);
            }

Hurt.Play();
        }
        

    }

}
