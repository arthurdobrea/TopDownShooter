using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject playerToFollow;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion lookRotation = Quaternion.LookRotation(playerToFollow.transform.position - transform.position);
        
        lookRotation.x = 0;
        lookRotation.z = 0;
        
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 7f * Time.deltaTime);
        
        
        transform.Translate(Vector3.forward * 7 * Time.deltaTime);
        
        
    }
}
