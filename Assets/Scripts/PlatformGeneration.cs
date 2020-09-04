using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour
{
    public GameObject Platform; // VARIAVEL PLATAFORM
    public Transform point; // PONTO DE CRIACAO DA PLATAFORM
    public float distMin; // DISTANCIA MININA DE CRIACAO
    public float disMax;// DISTANCIA MAXIMA DE CRIACAO

    private float platformWight; //REFERENCIANDO O COLIDER

    void Start()
    {
        // REFERENCIANDO A PLATFORM COM DOIS TIPOS E COLLDER
        if (Platform.GetComponent<BoxCollider2D>())
        {
            platformWight = Platform.GetComponent<BoxCollider2D>().size.x;
        }
        else
        {
            platformWight = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
    }
    void Update()
    {
        if (GameController.current.PlayerIsAlive)
        {
            //CRIACAO DA PLATAFORM INFINITA
            if (transform.position.x < point.position.x)
            {
                float Distace = Random.Range(distMin, disMax);
                transform.position = new Vector3(transform.position.x + platformWight + Distace, transform.position.y, transform.position.z);
                Instantiate(Platform, transform.position, transform.rotation);
            }
        }
    }
}
