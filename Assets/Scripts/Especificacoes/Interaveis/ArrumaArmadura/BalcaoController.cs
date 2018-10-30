using System.Collections;
using UnityEngine;

/// <summary>
/// Especificação da classe Fonte. O balcão será algo concreto e compreesível ao jogador, por isso é uma classe que serve apenas para herdar de Fonte.
/// </summary>
public class BalcaoController : Fonte {
    public float tempoAparecerObjetos;
    public Objeto objetoInstaciavel;
    /// <summary>
    /// Inicia uma corotina ao acordar.
    /// </summary>
    public void Awake()
    {
        StartCoroutine(CriarPedidos());
    }

    /// <summary>
    /// Corotina responsável por gerar as armaduras de bronze. Nesse caso, o objeto que será buscado está estático.
    /// </summary>
    /// <returns></returns>
    public IEnumerator CriarPedidos ()
    {
        for (int i = 0; i < 5; i++)
        {
            //Adiciona na lista de objetos, criada na classe Fonte.
            objetos.Add(Instantiate(objetoInstaciavel));
            yield return new WaitForSeconds(tempoAparecerObjetos);
        }
    }
}
