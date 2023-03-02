using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject ZombiePrefab;
    public float xSize;
    public float zSize;
    public SpawnManager spawnManager;
    public BoxCollider boxCollider;
    

    void Start()
    {
        xSize = boxCollider.size.x;
        zSize = boxCollider.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateZombie(int count)
    {
        for(int i = 0; i < count; i++)
        {
            //Vector3 transformNew = transform.position;
 
            GameObject zombie = Instantiate(ZombiePrefab, transform.position,Quaternion.identity,transform);
            spawnManager.increaseCount();
            zombie.GetComponent<EnemyHealth>().parentSpawner = spawnManager;
        }
    }

    private float GetRandom(float min, float max)
    {
        return Random.Range(min, max);
    }
}
    

