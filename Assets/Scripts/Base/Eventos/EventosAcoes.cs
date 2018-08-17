using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAcoes : MonoBehaviour
{
    public void InteragirFonte(GameObject fonte)
    {
        fonte.GetComponent<Fonte>().PegarObjeto(transform);
    }

    public void InteragirManipulador(GameObject manipulador)
    {
        Personagem p = transform.GetPersonagem();
        Manipulador m = manipulador.GetComponent<Manipulador>();

        if (p.ObjetoNaMao != null)
        {
            if (m.objeto == null)
            {
                m.DeixarManipulando(p);
            }
        }
        else if (m.objeto != null)
        {
            m.RetirarObjetoManipulacao(p);
        }
        else
        {
            Debug.LogError("Não há objeto na mão");
        }
    }


    public void InteragirReceptor(GameObject receptor)
    {        
        receptor.GetComponent<Receptor>().EntregarObjeto(transform.GetPersonagem());
    }

}
