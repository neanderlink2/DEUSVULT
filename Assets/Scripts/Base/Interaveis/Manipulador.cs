using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulador : Interavel
{
    public Objeto objeto;
    public bool isManipulando;

    public void GuardarObjeto(Objeto obj)
    {
        objeto = obj;
    }

    public Objeto RetirarObjetoGuardado()
    {
        if (objeto != null)
        {
            return objeto;
        }

        return null;
    }

    public void DeixarManipulando(Personagem p)
    {        
        if (p.ObjetoNaMao != null)
        {
            if (objeto == null)
            {
                GuardarObjeto(p.ObjetoNaMao);
                p.ObjetoNaMao = null;
                isManipulando = true;
                StartCoroutine(Manipular());
                Debug.Log("Colocou para manipular");
            }
        }
    }

    public void RetirarObjetoManipulacao(Personagem p)
    {
        if (isManipulando)
        {
            p.ObjetoNaMao = RetirarObjetoGuardado();
            isManipulando = false;
            objeto = null;
            Debug.Log("Retirou objeto antes de terminar");
        }
        else
        {
            p.ObjetoNaMao = RetirarObjetoGuardado();
            objeto = null;
            Debug.Log("Retirou objeto pronto");
        }
    }

    public IEnumerator Manipular()
    {
        Debug.Log("Manipulando...");
        objeto.estadoObj = EstadoObjeto.EmManipulacao;

        for (float i = objeto.tempoDecorrido; objeto != null && i < objeto.tempoParaFicarPronto; i += 0.01f)
        {
            if (!isManipulando)
            {
                break;
            }

            objeto.tempoDecorrido = i;

            StopCoroutine(Manipular());

            yield return new WaitForSeconds(0.01f);
        }

        if (objeto != null)
        {
            objeto.estadoObj = EstadoObjeto.Pronto;
            isManipulando = false;
            Debug.Log("Objeto pronto!");
        }
    }
}
