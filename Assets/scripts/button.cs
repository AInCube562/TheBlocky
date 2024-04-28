using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject[] objects = new GameObject[1];
    public Material plane;
    public Material btn2;
    public bool pressed;
    public float WaitSeconds;
    public GameObject f;
    float st = 0.75f;
    public bool inverse;
    Vector3 start;

    void OnTriggerEnter(Collider col)
    {
        if (f.transform.localPosition == start)
        {
            f.transform.localPosition += new Vector3(0, -st, 0);
        }
        pressed = true;
        Inv();

    }

    IEnumerator OnTriggerExit(Collider col)
    {
        yield return new WaitForSeconds(WaitSeconds);
        f.transform.localPosition += new Vector3(0, st, 0);
        pressed = false;
        Inv();

    }

    void Start()
    {
        start = f.transform.localPosition;
        Inv();

        
    }
    void FixedUpdate()
    {
     

        for (int i = 0; i < objects.Length; i++)
        {
            if (pressed)
            {
                objects[i].GetComponent<MeshRenderer>().material =  btn2;
                objects[i].GetComponent<BoxCollider>().isTrigger = true;
            }
            else
            {
                objects[i].GetComponent<MeshRenderer>().material = plane;
                objects[i].GetComponent<BoxCollider>().isTrigger = false;
            }

            
        }

        
     
    }
    void Inv()
    {
        if (inverse)
        {
            pressed = !pressed;
        }
    }
}
