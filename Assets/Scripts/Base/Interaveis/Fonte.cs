using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Fonte : Interavel
{
    public List<Objeto> objetos;

    public virtual void Awake ()
    {
        objetos = new List<Objeto>();
    }

    public void PegarObjeto ()
    {
        if (Personagem.ObjetoNaMao == null)
        {
            if (objetos.Count > 0)
            {
                Objeto a = objetos.ElementAt(0);
                objetos.Remove(a);
                Personagem.ObjetoNaMao = a;

                a.SetarMaoJogador(Personagem.name);
            }
            else
            {
                Debug.Log("Acabou os objetos desta fonte.");
            }
        }
        else
        {
            Debug.Log("Já tem um objeto na mão.");
        }
    }

}
