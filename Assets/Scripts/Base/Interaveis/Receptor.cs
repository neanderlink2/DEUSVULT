using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : Interavel {

    public List<Objeto> objetosEntregues;

    public void EntregarObjeto ()
    {
        if (Personagem.ObjetoNaMao.estadoObj == EstadoObjeto.Pronto)
        {
            objetosEntregues.Add(Personagem.ObjetoNaMao);
            Personagem.ObjetoNaMao.LimparMaoJogador(Personagem.name);
            Personagem.ObjetoNaMao = null;
            Debug.Log("Objeto entregue com sucesso!");
        }else
        {
            Debug.Log("Não pode entregar este objeto ainda. Ele não está pronto.");
        }
    }

}
