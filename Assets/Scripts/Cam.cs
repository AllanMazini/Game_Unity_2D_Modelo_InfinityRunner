using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private GameObject player; //REFERENCIANDO O PLAYER
    public float Speed; // VELOCIDADE DA CAMERA

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); // REFERENCIANDO O PLAYER PELA TAG
    }

    // Update is called once per frame
    void Update()
    {   
        // CRUANDO POSICAO E MOVIMENTACAO DA CAMERA COM PLAYER
        Vector3 newPosition=  new Vector3(player.transform.position.x + 5.8f, transform.position.y, transform.position.z); // POSICAO DE INICIO
        transform.position = Vector3.Lerp(transform.position, newPosition, Speed * Time.deltaTime); //MOVIMENTACAO DA CAMERA       
    }

}
 