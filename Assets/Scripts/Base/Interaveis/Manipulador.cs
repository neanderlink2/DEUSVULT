using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulador : Interavel
{
    public Objeto objeto;
    public bool isManipulando;
    private Color corNormal;

    private void Awake()
    {
        corNormal = GetComponent<Renderer>().material.color;
    }

    void Update ()
    {
        if (isManipulando)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }else
        {
            GetComponent<Renderer>().material.color = corNormal;
        }
    }

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

    public void DeixarManipulando()
    {        
        if (Personagem.ObjetoNaMao != null)
        {
            if (objeto == null)
            {
                GuardarObjeto(Personagem.ObjetoNaMao);
                Personagem.ObjetoNaMao.LimparMaoJogador(Personagem.name);
                Personagem.ObjetoNaMao = null;
                isManipulando = true;
                StartCoroutine(Manipular());
                Debug.Log("Colocou para manipular");
            }
        }
    }

    public void RetirarObjetoManipulacao()
    {
        if (isManipulando)
        {
            Personagem.ObjetoNaMao = RetirarObjetoGuardado();
            isManipulando = false;
            objeto = null;
            Debug.Log("Retirou objeto antes de terminar");
        }
        else
        {
            Personagem.ObjetoNaMao = RetirarObjetoGuardado();
            objeto = null;
            Debug.Log("Retirou objeto pronto");
        }

        Personagem.ObjetoNaMao.SetarMaoJogador(Personagem.name);
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
        }
    }
}
