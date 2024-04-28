using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public GameObject levelpanel;
    Scene scene;

    void Start()
    {

        scene = SceneManager.GetActiveScene();
        
    }

    public void NextLevel(bool next)
    {
        if (next)
        {
            SceneManager.LoadScene(scene.buildIndex + 1);
            


        }
        else
        {
            SceneManager.LoadScene(scene.buildIndex);
        }

    }

    public void DeleteProgress()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    
    public void Play()
    {
        levelpanel.SetActive(true);
    } 
}
