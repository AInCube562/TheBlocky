using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float speed;
    public float highjump;
    public GameObject f;
    public FixedJoystick joy;
    public Rigidbody rb;
    public bool jumping;
    public Vector3 hor;
    Quaternion startRot;

    void Awake()
    {
        startRot = transform.rotation;
        hor = Vector3.right;
        joy = f.GetComponent<FixedJoystick>();
    }

    public void Id()
    {
        transform.rotation = startRot;
    }

    void FixedUpdate()
    {
        Vector3 dir = Vector3.forward * joy.Vertical + hor * joy.Horizontal;
        rb.AddForce(dir * speed * Time.deltaTime, ForceMode.VelocityChange);
    }
}
