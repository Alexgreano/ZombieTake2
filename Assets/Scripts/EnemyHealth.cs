using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] public float maxHealth;
    Animator animator;
    float timer = 5;
    private bool isDead = false;
    public SpawnManager parentSpawner;

    /*public GameObject healthBar;
    public Slider slider;*/

    private void Start()
    {
        animator = GetComponent<Animator>();
        //slider.value = CalculatedHealth();

    }

    private void Update()
    {
        //slider.value = CalculatedHealth();

/*        if(health <= maxHealth)
        {
            healthBar.SetActive(true);
        }*/

        if ( health <= 0)
        {
            if(isDead == false)
            {
                animator.SetTrigger("Dead");
                isDead = true;
                parentSpawner.decreaseCount();

                Destroy(gameObject,5);

            }
        }
        //use if trying to have the enemy healed while fighting.
/*        if(health > maxHealth)
        {
            health = maxHealth;
        }*/
    }

/*    float CalculatedHealth()
    {
        return health / maxHealth;
    }*/

    public float Damage(float damage)
    {

        return health -= damage;
    }

    public float GetCurrentHealth()
    {
        return health;
    }



}
