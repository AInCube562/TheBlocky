using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public GameObject player;
    Vector3 p;
    Vector3 f;
    public bool x;
    public bool y;
    public bool z;


    void Start()
    {
        p = transform.position;
        f = p - player.transform.position;
    }

    void Update()
    {

        if (x)
        {
            p.x = player.transform.position.x + f.x ;
        }

        if (y)
        {
            p.y = player.transform.position.y + f.y;
        }

        if (z)
        {
            p.z = player.transform.position.z + f.z;
        }

        transform.position = p;

    }
}
