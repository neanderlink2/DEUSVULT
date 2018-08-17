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
        Manipulador m = manipulador.GetComponent<Manipulador>();

        if (m.Personagem.ObjetoNaMao != null)
        {
            if (m.objeto == null)
            {
                m.DeixarManipulando();
            }
        }
        else if (m.objeto != null)
        {
            m.RetirarObjetoManipulacao();
        }
        else
        {
            Debug.LogError("Não há objeto na mão");
        }
    }


    public void InteragirReceptor(GameObject receptor)
    {        
        receptor.GetComponent<Receptor>().EntregarObjeto();
    }

}
