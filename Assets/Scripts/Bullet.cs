using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    public float Speed; //VELOCIDADE DO TIRO
    public GameObject destBullet; // VARIAVEL DESTRUICAO DA BALA
    void Start() 
    {   
        //DESTRUINDO A BALA
        Destroy(destBullet, 2f);
    } 
    // Update is called once per frame
    void Update()
    {   
        //MOVIMENTO DO TIRO PARA FRENTE
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }
}
