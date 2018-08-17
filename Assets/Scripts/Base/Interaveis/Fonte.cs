using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Fonte : Interavel
{
    public List<Objeto> objetos;

    public void Awake ()
    {
        objetos = new List<Objeto>();
        for (int i = 0; i < 5; i++)
        {
            Objeto a = Instantiate(Resources.Load<Objeto>("Trigo"));

            objetos.Add(a);
        }
    }

    public void PegarObjeto (Transform t)
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
