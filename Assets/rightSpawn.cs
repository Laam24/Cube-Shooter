using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightSpawn : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        float randSpawn = Random.Range(1.5f, 3.5f);
        InvokeRepeating("spawn", 2.5f, randSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            
            CancelInvoke("spawn");
            
            
        }


    }

    void spawn()
    {
        float randomY = Random.Range(1f, 2.8f);

        Vector3 enemySpawn = new Vector3(10, randomY, 0);
        Instantiate(enemy, enemySpawn, Quaternion.identity);
    }
}
