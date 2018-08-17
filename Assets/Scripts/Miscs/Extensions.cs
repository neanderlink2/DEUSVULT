using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public static class Extensions
{

    public static bool IsIgual (this float num1, float num2)
    {
        if (num1 >= num2-0.1f && num1 <= num2+0.1f)
        {
            return true;
        }
        return false;
    }

    public static void SetarMaoJogador (this Objeto obj, string nomeJogador)
    {
        var numJogador = int.Parse(nomeJogador.ElementAt(nomeJogador.Length - 1).ToString());
        var layout = GameObject.Find("Canvas").transform.Find("MaoP" + numJogador);
        layout.GetComponentInChildren<Text>().text = "Mão do P" + numJogador + "\n" + obj.nome;
    }

    public static void LimparMaoJogador(this Objeto obj, string nomeJogador)
    {
        var numJogador = int.Parse(nomeJogador.ElementAt(nomeJogador.Length - 1).ToString());
        var layout = GameObject.Find("Canvas").transform.Find("MaoP" + numJogador);
        layout.GetComponentInChildren<Text>().text = "Mão do P"+numJogador;
    }

}
