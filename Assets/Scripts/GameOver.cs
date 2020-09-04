using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        
        if (collision.gameObject.tag == "Player")
        {
            GameController.current.PainelGameOver.SetActive(true);
            GameController.current.PlayerIsAlive = false;
            Destroy(collision.gameObject);
        }
    }
}
