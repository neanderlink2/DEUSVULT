using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public static class Extensions
{

    public static bool IsIgual(this float num1, float num2)
    {
        if (num1 >= num2 - 0.1f && num1 <= num2 + 0.1f)
        {
            return true;
        }
        return false;
    }

    public static void SetarMaoJogador(this Objeto obj, string nomeJogador)
    {
        var numJogador = int.Parse(nomeJogador.ElementAt(nomeJogador.Length - 1).ToString());

        var prefab = Resources.Load<GameObject>("Prefabs/"+obj.nome);
        var mao = GameObject.Find("Player" + numJogador).transform.Find("Mao");
        GameObject.Instantiate(prefab, mao.position, Quaternion.Euler(0, 0, 90), mao);
    }

    public static void LimparMaoJogador(this Objeto obj, string nomeJogador)
    {
        var numJogador = int.Parse(nomeJogador.ElementAt(nomeJogador.Length - 1).ToString());

        var mao = GameObject.Find("Player" + numJogador).transform.Find("Mao");

        for (int i = 0; i < mao.childCount; i++)
        {
            GameObject.Destroy(mao.GetChild(i).gameObject);
        }

    }

}
