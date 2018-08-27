using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manipulador : Interavel
{
    public Objeto objeto;
    public bool isManipulando;
    private Color corNormal;

    [SerializeField]
    protected Color corUsando = Color.red;

    private void Awake()
    {
        corNormal = GetComponent<Renderer>().material.color;
    }

    new void Update ()
    {
        if (isManipulando)
        {
            GetComponent<Renderer>().material.color = corUsando;
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

    public void Manipulacao ()
    {
        if (Personagem.ObjetoNaMao != null)
        {
            if (objeto == null)
            {
                DeixarManipulando();
            }
        }
        else if (objeto != null)
        {
            RetirarObjetoManipulacao();
        }
        else
        {
            Debug.LogError("Não há objeto na mão");
        }
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
            MyCanvas.BarraFornalha.gameObject.SetActive(false);
            MyCanvas.BarraFornalha.value = 0;
            Debug.Log("Retirou objeto pronto");
        }

        Personagem.ObjetoNaMao.SetarMaoJogador(Personagem.name);
    }

    public IEnumerator Manipular()
    {
        Debug.Log("Manipulando...");
        objeto.estadoObj = EstadoObjeto.EmManipulacao;
        MyCanvas.BarraFornalha.gameObject.SetActive(true);
        MyCanvas.BarraFornalha.maxValue = objeto.tempoParaFicarPronto;

        for (float i = objeto.tempoDecorrido; objeto != null && i < objeto.tempoParaFicarPronto; i += 0.01f)
        {
            if (!isManipulando)
            {
                break;
            }

            objeto.tempoDecorrido = i;
            MyCanvas.BarraFornalha.value = i;

            yield return new WaitForSeconds(0.01f);
        }

        if (objeto != null)
        {
            
            if (objeto is ObjetoAperfeicoavel && objeto.estadoObj != EstadoObjeto.Pronto)
            {
                objeto.estadoObj = EstadoObjeto.PreparadoParaAperfeicoar;
            }else
            {
                objeto.estadoObj = EstadoObjeto.Pronto;
            }
            isManipulando = false;
        }
    }
}
