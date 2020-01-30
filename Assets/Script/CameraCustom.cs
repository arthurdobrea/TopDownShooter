using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCustom : MonoBehaviour
{
    public Transform player;
    public float smooth = 0.3f;
    public float hight;

    private Vector3 velocity = Vector3.zero;

    private Vector3 position;    
    // Start is called before the first frame update
    void Start()
    {
        position = new Vector3();
        
    }

    // Update is called once per frame
    void Update()
    {
        position.x = player.position.x;
        position.y = player.position.y + hight;
        position.z = player.position.z -7f;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref velocity, smooth);
    }
}
