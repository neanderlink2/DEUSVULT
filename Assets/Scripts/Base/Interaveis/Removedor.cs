using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
/// <summary>
/// Interável que permite apagar o objeto que está na mão do jogador.
/// </summary>
public class Removedor : Interavel
{
    /// <summary>
    /// Apaga a referência do objeto que está na mão do jogador;
    /// </summary>
    public void JogarObjetoFora()
    {
        if (Personagem.ObjetoNaMao != null)
        {
            Personagem.ObjetoNaMao = null;
            Destroy(Personagem.transform.Find("Mao").GetChild(0).gameObject);
        }
        else
        {
            Debug.Log("Não tem nada na mão.");
        }
    }
}
