using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text txtPontos;
    public Text life;


    public GameObject painelGame;

    private void Start()
    {
        painelGame.SetActive(false);
    }
    public void Ponts(int p)
    {
        txtPontos.text = p.ToString();
    }

    public void Damage(int l)
    {
        life.text = l.ToString();
    }

    public void Painel()
    {
        painelGame.SetActive(true);
    }

    public void SkipScene(int i)
    {
        SceneManager.LoadScene(i);
    }

}
