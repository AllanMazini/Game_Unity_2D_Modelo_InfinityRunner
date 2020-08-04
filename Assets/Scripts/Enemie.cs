using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    public float Speed;

    private Transform backPoint;

    private Animator anim;

    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        backPoint = GameObject.FindGameObjectWithTag("backPoint").GetComponent<Transform>(); 
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * Speed * Time.deltaTime);
        rig.velocity = new Vector2 (-Speed * Time.deltaTime, rig.velocity.y);

         if (transform.position.x < backPoint.position.x)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.tag =="bullet")
        {
            anim.SetTrigger("destroy");
            Destroy(gameObject, 2f);
        }

    }
}
