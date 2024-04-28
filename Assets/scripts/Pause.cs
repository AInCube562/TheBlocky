using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    
    void Start()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    public void pas()
    {
        if(Time.timeScale > 0)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }
}
