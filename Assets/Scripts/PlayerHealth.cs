using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health;
    [SerializeField] public float maxHealth;
    private bool isDead = false;

/*    public GameObject healthBar;
    public Slider slider;
*/
    private void Start()
    {
        
        //slider.value = CalculatedHealth();

    }

    private void Update()
    {
        //slider.value = CalculatedHealth();

/*        if (health <= maxHealth)
        {
            healthBar.SetActive(true);
        }*/

        if (health <= 0)
        {
            if (isDead == false)
            {
                isDead = true;
                Destroy(gameObject, 15);
                
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
}
