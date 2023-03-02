using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float health;
    public float maxHealth;
    private bool isAlive = true;
    public Animator animator;
    public float deathTimer = 0;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        

        if(isAlive && health <= 0)
        {
            animator.SetTrigger("Death");
            Destroy(gameObject, deathTimer);
        } 
    }

    public void InflictDamage(float damageAmount)
    {
        health -= damageAmount;
    }

    public void GainHealth(float healthAmount)
    {
        health += healthAmount;
    }
}
