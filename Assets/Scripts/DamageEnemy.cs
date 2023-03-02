using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour
{
    [SerializeField] float damage = 0;
    [SerializeField] bool oneTime = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!oneTime) return;


        if (other.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth health))
        {
            if(health.GetCurrentHealth() > 0)
            {
                health.Damage(damage);
            }
            
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (oneTime) return;

        if (other.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth health))
        {
            if (health.GetCurrentHealth() > 0)
                health.Damage(damage * Time.deltaTime);
        }
    }


    private void OnCollisionEnter(Collision other)
    {
        if (!oneTime) return;

        if (other.gameObject.TryGetComponent<EnemyHealth>(out EnemyHealth health))
        {
            if (health.GetCurrentHealth() > 0)
            {
                health.Damage(damage);
            }
        }
    }
}