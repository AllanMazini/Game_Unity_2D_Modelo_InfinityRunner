using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed; // VELOCIDADE DO PLAYER

    private bool isJump; // VARIAVEL SE O PERSONAGEM ESTA NO CHAO
    public float JumpForca; // FORCA DO PULO

    public GameObject bullet; // VARIAVEL DA BALA
    public Transform firePoint; // VARIAVEL DO PONTO DE SAIDA DA BALA

    public GameObject smoke; // VARIAVEL DA ATIVACAO DA FUMACA DO PULO

    private Rigidbody2D rig; // VARIAVEL DE REFERENCIA

    

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>(); // REFERENCIA O RIGIDBODY

        AudioContrloller.current.PlayClip(AudioContrloller.current.bg);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // REFERENCIA PARA ANDAR COM O PLAYER PARA FRENTE.
        rig.velocity = new Vector2(Speed * Time.deltaTime, rig.velocity.y);

        //BOTAO DE PULO DO PLAYER
        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rig.AddForce(Vector2.up * JumpForca, ForceMode2D.Impulse); //PULO
            isJump = true; // SE ESTRA NO CHAO
            smoke.SetActive(true); // ATIVADOR DA FUMACA

        }
        

        //BOTAO DE TIRO
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation); // REFERENCIANDO A BALA E O PONTO DE SAIDA DA BALA
        }

    }

    public void JumpBtn()
    {

        if (!isJump)
        {
            rig.AddForce(Vector2.up * JumpForca, ForceMode2D.Impulse); //PULO
            isJump = true; // SE ESTRA NO CHAO
            smoke.SetActive(true); // ATIVADOR DA FUMACA
            AudioContrloller.current.PlayClip(AudioContrloller.current.fx1);

        }

    }
    public void FireBtn()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        AudioContrloller.current.PlayClip(AudioContrloller.current.fx2);
    }

    // COLISAO IF SE O PERSONAGEM ESTA NO CHAO, FAZ COM QUE O PERSONAGEM PULE SO UMA VEZ
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.layer == 8)
        {
            isJump = false;
            smoke.SetActive(false);
        }


    }


    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "coin")
        {
            GameController.current.AddScore(5);
            Destroy(colision.gameObject);
        }

        if (colision.gameObject.tag == "Enemy")
        {

            GameController.current.PainelGameOver.SetActive(true);
            GameController.current.PlayerIsAlive = false;
            Destroy(gameObject);
           

        }
    }



}
