using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsGeneration : MonoBehaviour
{
   private Coins Coin; // VARIAVEL PLATAFORM

    public List<GameObject> Coins = new List<GameObject>();
    public Transform point; // PONTO DE CRIACAO DA PLATAFORM
    public float distMin; // DISTANCIA MININA DE CRIACAO
    public float disMax;// DISTANCIA MAXIMA DE CRIACAO

    // private float platformWight; //REFERENCIANDO O COLIDER


    void Start()
    {
       
    }
    void Update()
    {
        if (GameController.current.PlayerIsAlive)
        {
            //CRIACAO DA PLATAFORM INFINITA
            if (transform.position.x < point.position.x)
            {
                float Distace = Random.Range(distMin, disMax);

                int CoinsRandom = Random.Range(0, Coins.Count);

              
                transform.position = new Vector3(transform.position.x + Distace, Random.Range(0f,1f), transform.position.z);

                Coin = Instantiate(Coins[CoinsRandom], transform.position, transform.rotation).GetComponent<Coins>();
            }
        }
    }
}
