using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    GameObject lastspawned;
    public GameObject enemy;
    float timer = 5f;
    float spawntimer = 7f;
    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;
    public Transform spawn4;
    public Transform spawn5;
    public Transform spawn6;
    public Transform spawn7;

    public Transform spawn8;

    //public Transform[] spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawntimer > 1)
        {
            spawntimer -= Time.deltaTime / 10;
        }

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Spawn();
            timer = spawntimer;
        }
    }

    public void Spawn()
    {
        int random = Random.Range(0, 8);
        
        if (random == 1)
        {
            Instantiate(enemy, spawn1.position, Quaternion.identity);
        }
        if (random == 2)
        {
            Instantiate(enemy, spawn2.position, Quaternion.identity);
        }
        if (random == 3)
        {
            Instantiate(enemy, spawn3.position, Quaternion.identity);
        }
        if (random == 4)
        {
            Instantiate(enemy, spawn4.position, Quaternion.identity);
        }
        if (random == 5)
        {
            Instantiate(enemy, spawn5.position, Quaternion.identity);
        }
        if (random == 6)
        {
            Instantiate(enemy, spawn6.position, Quaternion.identity);
        }
        if (random == 7)
        {
            Instantiate(enemy, spawn7.position, Quaternion.identity);
        }
        if (random == 8)
        {
            Instantiate(enemy, spawn8.position, Quaternion.identity);
        }
        //  Instantiate(enemy, spawnpos[random]);

    }
}
