using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerToFollow;
    public GameObject bulletSpawnPoint;
    public GameObject bullet;
    public float wait;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        wait += 1 * Time.deltaTime;
        if (wait >= 2)
        {
            shoot();
            wait = 0;
        }
        
        var selfPosition = transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(playerToFollow.transform.position - selfPosition);

        lookRotation.x = 0;
        lookRotation.z = 0;

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 7f * Time.deltaTime);

        float distance = Vector3.Distance(selfPosition, playerToFollow.transform.position);
        if (distance >= 3f)
        {
            transform.Translate(Vector3.forward * 7 * Time.deltaTime);
        }
    }

    void shoot()
    {
        Instantiate(bullet.transform, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }
}