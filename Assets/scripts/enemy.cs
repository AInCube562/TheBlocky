using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Vector3 start;
    public bool go = false;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player" && go)
        {
            transform.position = start;
        }
    }
}
