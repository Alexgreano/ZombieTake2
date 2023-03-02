using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlaye : MonoBehaviour
{
    [SerializeField] float damage = 0;
    [SerializeField] bool oneTime = true;

    private void OnTriggerEnter(Collider other)
    {
        if (!oneTime) return;

        if (other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth health))
        {
            health.Damage(damage);
            Debug.Log(damage);
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (oneTime) return;

        if (other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth health))
        {
            health.Damage(damage * Time.deltaTime);
        }
    }*/


    private void OnCollisionEnter(Collision other)
    {
        if (!oneTime) return;

        if (other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth health))
        {
            health.Damage(damage);
            Debug.Log(damage);
        }
    }
}
