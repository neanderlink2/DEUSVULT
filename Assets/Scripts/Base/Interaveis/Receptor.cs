using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receptor : Interavel {

    public List<Objeto> objetosEntregues;

    public void EntregarObjeto (Personagem personagem)
    {
        if (personagem.ObjetoNaMao.estadoObj == EstadoObjeto.Pronto)
        {
            objetosEntregues.Add(personagem.ObjetoNaMao);
            personagem.ObjetoNaMao = null;
            Debug.Log("Objeto entregue com sucesso!");
        }else
        {
            Debug.Log("Não pode entregar este objeto ainda. Ele não está pronto.");
        }
    }

}
