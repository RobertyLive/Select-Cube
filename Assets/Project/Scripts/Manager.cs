using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject painel;
    public Text guardarPontos;

    public void Start()
    {
        painel.SetActive(false);
        guardarPontos.text = PlayerPrefs.GetInt("pontos").ToString();
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void SkipScene(int i)
    {
        SceneManager.LoadScene(i);

        if(i == 1)
        {
            PlayerPrefs.DeleteKey("pontos");
        }
    }

    public void Credits()
    {
        painel.SetActive(true);
    }

    
}
