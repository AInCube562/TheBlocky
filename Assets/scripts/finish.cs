using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameObject winScreen;

    void Start()
    {
        winScreen.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            winScreen.SetActive(true);
        }
        
    }
}
