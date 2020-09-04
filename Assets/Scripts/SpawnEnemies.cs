using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float inicialTime;
    public float minTime;
    public float maxTime;

    public List<GameObject> ListEnemies = new List<GameObject>(); 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timeCount;
    // Update is called once per frame
    void Update()
    { 
        if(GameController.current.PlayerIsAlive){
        timeCount += Time.deltaTime;

        if (timeCount >= inicialTime)
        {
            Instantiate(ListEnemies[Random.Range(0, ListEnemies.Count)], transform.position + new Vector3(0, Random.Range(-1f,4f),0), transform.rotation);
            inicialTime = Random.Range(minTime,maxTime);

            timeCount = 0;
        }

     } }
}
