using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Fonte : Interavel
{
    public List<Objeto> objetos;

    public void Awake ()
    {
        objetos = new List<Objeto>();
        for (int i = 0; i < 5; i++)
        {
            Objeto a = ScriptableObject.CreateInstance<Objeto>();
            a.nome = "Trigo";
            a.tempoParaFicarPronto = 5;
            a.estadoObj = EstadoObjeto.Inicial;
            objetos.Add(a);
        }
    }

    public void PegarObjeto (Transform t)
    {
        Personagem p = t.GetPersonagem();

        if (p.objetoNaMao == null)
        {
            if (objetos.Count > 0)
            {
                Objeto a = objetos.ElementAt(0);
                objetos.Remove(a);
                p.objetoNaMao = a;
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
