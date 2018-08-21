using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Aperfeicoador : Interavel
{
    public Objeto obj;
    public bool isAperfeicoando;



    protected override void OnTriggerStay(Collider collider)
    {
        if (collider.GetComponent<Personagem>() != null)
        {
            Personagem = collider.GetComponent<Personagem>();
            if (Input.GetKey(Personagem.botaoInteracao))
            {
                OnInteragiu.Invoke(null);
            }
        }
    }

    public void Aperfeicoar ()
    {
        if (Personagem.ObjetoNaMao != null)
        {
            VerificarObjetoAperfeicoavel();
        }
        else
        {
            Debug.Log("Não tem nada na mão.");
        }
    }

    private void VerificarObjetoAperfeicoavel()
    {
        if (Personagem.ObjetoNaMao is ObjetoAperfeicoavel)
        {
            DeixarAperfeicoando();
        }
        else
        {
            Debug.Log("Esse objeto não precisa de aperfeiçoamento");
        }
    }

    private void DeixarAperfeicoando()
    {
        if (Personagem.ObjetoNaMao.estadoObj == EstadoObjeto.PreparadoParaAperfeicoar || Personagem.ObjetoNaMao.estadoObj == EstadoObjeto.EmAperfeicoamento)
        {
            var obj = Personagem.ObjetoNaMao as ObjetoAperfeicoavel;
            if (obj.tempoDecorridoAperfeicoamento < obj.tempoAperfeicoamento)
            {
                obj.estadoObj = EstadoObjeto.EmAperfeicoamento;
                obj.tempoDecorridoAperfeicoamento += 1 * Time.deltaTime;
            }
            else
            {
                obj.estadoObj = EstadoObjeto.Pronto;
            }
        }
        else
        {
            Debug.Log("Esse objeto não está pronto para aperfeiçoar");
        }
    }
}

