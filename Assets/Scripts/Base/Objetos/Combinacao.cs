using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Classe responsável por criar as combinações de objetos.
/// </summary>
[CreateAssetMenu(menuName = "Objetos/Combinações...", fileName = "Combinacao")]
public class Combinacao : ScriptableObject
{
    /// <summary>
    /// Ingredientes que serão necessários.
    /// </summary>
    public List<Objeto> ingredientes = new List<Objeto>(2);
    /// <summary>
    /// Objeto que será resultado caso todos os ingredientes sejam fornecidos.
    /// </summary>
    public Objeto resultado;

    /// <summary>
    /// Verifica se todos os ingredientes foram fornecidos corretamente.
    /// </summary>
    /// <param name="objetos">Array dos objetos.</param>
    /// <returns></returns>
    public bool VerificarIngredientes(Objeto[] objetos)
    {
        //Cria uma nova lista de objetos e coloca todos os ingredientes necessários.
        var ing = new List<Objeto>();
        ingredientes.ForEach(x => ing.Add(x));

        //Verifica se a lista tem o ingrediente e retira esse ingrediente da lista caso exista.
        if (ing.Where(x => x.nome.Equals(objetos[0].nome)).Count() > 0)
        {
            ing.Remove(ing.Where(x => x.nome.Equals(objetos[0].nome)).FirstOrDefault());
        }

        if (ing.Where(x => x.nome.Equals(objetos[1].nome)).Count() > 0)
        {
            ing.Remove(ing.Where(x => x.nome.Equals(objetos[1].nome)).FirstOrDefault());
        }


        //Se a lista de ingredientes estiver vazia ao término do algoritmo, retorna true, se não retorna false.
        if (ing.Count > 0)
        {
            return false;
        }else
        {
            return true;
        }
    }
}
