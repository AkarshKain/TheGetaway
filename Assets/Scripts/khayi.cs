using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khayi : MonoBehaviour
{
    [SerializeField] private Transform player1;
    [SerializeField] private Transform player2;
    [SerializeField] private Transform respawn_point1;
    [SerializeField] private Transform respawn_point2;





    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.tag == "Player1")
        {player1.transform.position = respawn_point1.position;
        FindObjectOfType<GameHandler>().hurtp1(); }

        if (other.tag == "Player2")

        {
            player2.transform.position = respawn_point2.position;
            FindObjectOfType<GameHandler>().hurtp2();

        }



    }
	
}
