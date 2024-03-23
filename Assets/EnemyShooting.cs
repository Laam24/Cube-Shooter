using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject enemyBullet;
    public Transform bulletPos;

    GameObject player;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float timeGap = Random.Range(1.7f, 2.7f);

        if(timer > timeGap && player != null)
        {
            timer = 0;
            shoot();
        }
    }

    void shoot()
    {
        Instantiate(enemyBullet, bulletPos.position, Quaternion.identity);
    }
}
