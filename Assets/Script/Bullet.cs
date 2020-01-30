using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float timeToDie;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        timeToDie += 1 * Time.deltaTime;
        if (timeToDie >= 3)
        {
           Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
