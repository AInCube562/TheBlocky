using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Btn : MonoBehaviour
{
    public int ind;
    public Text txt;

    void Start()
    {
        if (PlayerPrefs.GetInt("level" + ind.ToString()) <= 0 && ind > 1)
        {
            gameObject.SetActive(false);
        }
    }

    void Update()
    {
        txt.text = ind.ToString();
        
       
    }

    public void LoadLvl()
    {
        SceneManager.LoadScene(ind);
    }
}
