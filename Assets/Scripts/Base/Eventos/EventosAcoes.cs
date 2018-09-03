using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe Helper para execuçãodos eventos. Servem apenas para chamar métodos, não codificar lógica nesta classe.
/// </summary>
public class EventosAcoes : MonoBehaviour
{
    /// <summary>
    /// Interação da Fonte.
    /// </summary>
    /// <param name="fonte">GameObject da fonte</param>
    public void InteragirFonte(GameObject fonte)
    {
        fonte.GetComponent<Fonte>().PegarObjeto();
    }

    /// <summary>
    /// Interação do Manipulador.
    /// </summary>
    /// <param name="manipulador">GameObject do manipulador</param>
    public void InteragirManipulador(GameObject manipulador)
    {
        manipulador.GetComponent<Manipulador>().Manipulacao();
    }

    /// <summary>
    /// Interação do Receptor.
    /// </summary>
    /// <param name="receptor">GameObject do receptor</param>
    public void InteragirReceptor(GameObject receptor)
    {        
        receptor.GetComponent<Receptor>().EntregarObjeto();
    }

    /// <summary>
    /// Interação do Aperfeiçoador.
    /// </summary>
    /// <param name="aperfeicoador">GameObject do aperfeiçoador</param>
    public void InteragirAperfeicoador (GameObject aperfeicoador)
    {
        aperfeicoador.GetComponent<Aperfeicoador>().Aperfeicoar();        
        
    }

    /// <summary>
    /// Interação do Armazenador.
    /// </summary>
    /// <param name="armazenador">GameObject do armazenador</param>
    public void InteragirArmazenador (GameObject armazenador)
    {
        armazenador.GetComponent<Armazenador>().ArmazenarObjeto();
    }

}
