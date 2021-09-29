using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Text txtPontos;
    public Text life;

    public void Ponts(int p)
    {
        txtPontos.text = p.ToString();
    }

    public void Damage(int l)
    {
        life.text = l.ToString();
    }

}
