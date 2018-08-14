using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAcoes : MonoBehaviour {

    public void InteragirFonte (GameObject fonte)
    {
        fonte.GetComponent<Fonte>().PegarObjeto(transform);
        Debug.Log("Pegou um objeto");
    }

    public void InteragirManipulador (GameObject manipulador)
    {
        Personagem p = transform.GetPersonagem();
        Manipulador m = manipulador.GetComponent<Manipulador>();

        if (p.objetoNaMao != null)
        {
            if (m.objeto == null)
            {
                m.GuardarObjeto(p.objetoNaMao);
                p.objetoNaMao = null;
                m.isManipulando = true;
                StartCoroutine(m.Manipular());
                Debug.Log("Colocou para manipular");
            }
        }
        else if (m.objeto != null)
        {
            if (m.isManipulando)
            {
                p.objetoNaMao = m.RetirarObjetoGuardado();
                m.isManipulando = false;
                m.objeto = null;
                Debug.Log("Retirou objeto antes de terminar");
            }
            else
            {
                p.objetoNaMao = m.RetirarObjetoGuardado();
                m.objeto = null;
                Debug.Log("Retirou objeto pronto");
            }
        }
        else
        {
            Debug.LogError("Não há objeto na mão");
        }
    }
}
