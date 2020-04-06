using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    private Rigidbody2D RB;
    public GameObject bulleteffect;


    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(speed * transform.localScale.x, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            FindObjectOfType<GameHandler>().hurtp1();
        }

        if (other.tag == "Player2")
        {
            FindObjectOfType<GameHandler>().hurtp2();
        }

        Instantiate(bulleteffect, transform.position, transform.rotation);


        Destroy(gameObject);

    }
}

