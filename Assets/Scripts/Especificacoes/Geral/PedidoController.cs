using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class PedidoController : MonoBehaviour
{
    public List<Pedido> pedidos;
    [Tooltip("Tempo necessário para que um novo pedido seja adicionado.")]
    public float tempoNovoPedido = 50f;

    public void Start()
    {
        StartCoroutine(Get());
    }

    public IEnumerator Get()
    {
        var p = Instantiate<Pedido>(Resources.Load<Pedido>("Objetos/Pedido_ArmaduraTrigo"));

        pedidos.Add(p);
        var prefPedido = Instantiate(Resources.Load<GameObject>("Prefabs/Pedido"), MyCanvas.PainelPedido);
        prefPedido.GetComponentInChildren<Text>().text = "Pedido\n" + p.objetoNecessario.nome;

        for (float i = 0; i < tempoNovoPedido; i += 0.01f)
        {
            yield return new WaitForSeconds(0.01f);
        }
        StartCoroutine(Get());
    }

}
