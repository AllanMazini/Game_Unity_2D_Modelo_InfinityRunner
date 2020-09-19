using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private Transform backPoint; // VARIAVEL PONTO DE DESTRUICAO DAS PLATAFORMAS
    void Start()
    {   
        //REFERENCIANDO A VARIAVEL
        backPoint = GameObject.FindGameObjectWithTag("backPoint").GetComponent<Transform>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        //REFENCIANDO A POSICAO E A DESTRUICAO DAS PLATAFORMAS
        if (transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
        
    }
}