using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class options : MonoBehaviour
{
    Slider sl;

    void Start()
    {
        sl = GetComponent<Slider>();
        if (PlayerPrefs.HasKey("volume"))
        {
            sl.value = PlayerPrefs.GetFloat("volume");
        }
    }

    void Update()
    {
        PlayerPrefs.SetFloat("volume", sl.value);
        
    }

}
