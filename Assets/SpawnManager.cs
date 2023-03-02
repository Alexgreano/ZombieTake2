using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<ZombieSpawner> spawners = new List<ZombieSpawner>();
    public int zombieCount = 0;
    public int zombieSpawnerCount = 2;
    public float timer = 0;
    private bool hasSetTime = false;

    void Start()
    {
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > -1) timer -= Time.deltaTime;

        if (zombieCount == 0 && !hasSetTime) 
        { 
            timer = 10;
            hasSetTime = true;
        }


        if(zombieCount == 0 && timer <= 0)
        {
            zombieSpawnerCount++;
            foreach(ZombieSpawner spawner in spawners)
            {
                spawner.CreateZombie(zombieSpawnerCount);
            }

            hasSetTime = false;
        }
    }

    public void decreaseCount()
    {
        zombieCount--;
    }

    public void increaseCount()
    {
        zombieCount++;
    }
}
