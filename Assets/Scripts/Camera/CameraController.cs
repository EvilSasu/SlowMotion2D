using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
            transform.position = new Vector3(player.transform.position.x,
                transform.position.y, transform.position.z);
    }
}
