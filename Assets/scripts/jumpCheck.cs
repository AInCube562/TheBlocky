using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpCheck : MonoBehaviour
{
    movePlayer mv;
    public GameObject cam;
    public GameObject start;
    Vector3 startPosition;
    AudioSource background;
    playerSpunds pl;
    int score = 0;
    float startgr;
    Rigidbody rb;

    public void Jump()
    {
        if (!mv.jumping)
        {
            if(Physics.gravity.y > 0)
            {
                rb.AddForce(Vector3.down * mv.highjump  , ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(Vector3.up * mv.highjump  , ForceMode.Impulse);
            }
            
            mv.jumping = true;
        }


    }

    void Awake()
    {

        rb = GetComponent<Rigidbody>();
        pl = GetComponent<playerSpunds>();
        mv = cam.GetComponent<movePlayer>();
        startPosition = start.transform.position;
        background = GetComponent<AudioSource>();
        background.volume = PlayerPrefs.GetFloat("volume");
        startgr = Physics.gravity.y;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "fin")
        {
            score++;
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, score);
            Time.timeScale = 0;
            background.Pause();
            pl.sounds[0].Play();
        }

        if (col.gameObject.tag == "enemy")
        {
            pl.sounds[1].Play();
            gameObject.transform.position = startPosition;
            gameObject.transform.rotation = Quaternion.identity;
            rb.Sleep();
            mv.Id();
            Physics.gravity = new Vector3(0, startgr, 0);
            mv.hor = Vector3.right;
        }

        if (col.gameObject.tag == "topdownBonus")
        {
            col.gameObject.transform.Rotate(0, 0, 180);
            cam.transform.Rotate(0, 0, 180);
            Physics.gravity *= -1;
            mv.hor *= -1;
        }
    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.tag == "ground")
        {
            mv.jumping = false;
        }
    }


}

