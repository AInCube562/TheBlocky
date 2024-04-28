using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBlocks : MonoBehaviour
{
    public float speed;
    public int[] axis = new int[3];
    float[] speeds;

    void Start()
    {
        speeds = new float[3] { speed * axis[0], speed * axis[1], speed * axis[2]};
    }

    void FixedUpdate()
    {
        gameObject.transform.Translate(new Vector3(speeds[0], speeds[1], speeds[2]));
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "movingTrigger")
        {
            for(int i = 0; i <3; i++)
            {
                speeds[i] = -speeds[i];
            }
            
        }
    }
}
