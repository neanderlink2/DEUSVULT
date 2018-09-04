using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe responsável por controlar os pedidos. Mantém uma lista de pedidos que será incrementada em um intervalo determinado pelo campo 'tempoNovoPedido'.
/// </summary>
public class PedidoController : MonoBehaviour
{
    [Tooltip("Lista de pedidos que poderão ser instanciados")]
    public List<Pedido> pedidosPossiveis;

    [Tooltip("Tempo necessário para que um novo pedido seja adicionado.")]
    public float tempoNovoPedido = 50f;

    /// <summary>
    /// Lista de pedidos que estão em andamento.
    /// </summary>
    public List<Pedido> pedidosAndamento;

    /// <summary>
    /// Cria um novo pedido no início da execução.
    /// </summary>
    public void Start()
    {
        //Chama uma nova Corotina que gera o primeiro pedido.
        StartCoroutine(GeraPedido());
    }

    /// <summary>
    /// Corotina que gera um novo pedido em um determinado periodo de tempo.
    /// </summary>
    /// <returns></returns>;
    public IEnumerator GeraPedido()
    {
        //Instancia um pedido e o adiciona na lista de pedidos em andamento.
        Pedido p = InstanciaPedido();
        pedidosAndamento.Add(p);

        //Instancia o prefab do objeto e o adiciona no PainelPedido para mostrar o pedido ao jogador.
        var prefPedido = Instantiate(Resources.Load<GameObject>("Prefabs/Pedido"), MyCanvas.PainelPedido);
        prefPedido.GetComponentInChildren<Text>().text = "Pedido\n" + p.objetoNecessario.nome;

        //Espera os segundos determinados no Inspector.
        yield return new WaitForSeconds(tempoNovoPedido);

        //Quando termina essa corotina, uma nova entra em execução para gerar outros pedidos.
        StartCoroutine(GeraPedido());
    }

    /// <summary>
    /// Instancia um novo pedido aleatório, de acordo com a lista de pedidos possíveis.
    /// </summary>
    /// <returns></returns>
    private Pedido InstanciaPedido()
    {
        var r = UnityEngine.Random.Range(0, pedidosPossiveis.Count);
        var pedidoRand = pedidosPossiveis[r];
        var p = Instantiate<Pedido>(pedidoRand);
        return p;
    }
}
