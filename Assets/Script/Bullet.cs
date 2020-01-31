using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float timeToDie;

    void Update()
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        timeToDie += 1 * Time.deltaTime;
        if (timeToDie >= 3)
        {
           Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
        if (other.CompareTag("Human"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }    
}
