using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GunShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform fireTransform;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg0)
    {
        GameObject spawnedObject = Instantiate(bullet);
        spawnedObject.transform.position = fireTransform.position;
        spawnedObject.GetComponent<Rigidbody>().velocity = (fireTransform.forward) * speed;
        Destroy(spawnedObject, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
