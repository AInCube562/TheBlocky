using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpunds : MonoBehaviour
{
    public AudioSource[] sounds = new AudioSource[3];

    void Start()
    {
        for(int i = 0; i < sounds.Length; i++)
        {
            sounds[i].volume *= PlayerPrefs.GetFloat("volume");
        }
    }

}
