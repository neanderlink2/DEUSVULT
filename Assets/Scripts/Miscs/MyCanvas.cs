using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Classe Helper para usar as interfaces gráficas. Essa classe contém apenas métodos e propriedades estáticas pois serão acessadas sem necessidade de instância da classe MyCanvas.
/// Isso é bastante útil para não precisar ficar codificando a busca do GameObject sempre que necessitar da interface gráfica. 
/// </summary>
public static class MyCanvas
{
    /// <summary>
    /// Essa propriedade buscará todas as barras de tarefas do jogador 1, jogador 2 e jogador 3. Essa barra de tarefa será usada para mostrar quando um aperfeiçoamento está pronto.
    /// </summary>
    public static Slider[] BarrasTarefa
    {
        get
        {
            var g = Resources.FindObjectsOfTypeAll<Slider>().Where(x => x.CompareTag("BarraTarefa")).ToArray();            
            return g;
        }
    }

    /// <summary>
    /// Essa propriedade buscará a barra de progresso da fornalha. Essa barra é usado para mostrar o status de uma manipulação.
    /// </summary>
    public static Slider BarraFornalha
    {
        get
        {
            var g = GameObject.Find("CanvasWorld").transform.Find("BarraFornalha");
            return g.GetComponent<Slider>();
        }
    }

    /// <summary>
    /// Essa propriedade buscará o PainelPedido. Especificamente, buscará o filho Content deste ScrollView, pois é no Content que o conteúdo de um ScrollView deve ficar.
    /// </summary>
    public static RectTransform PainelPedido
    {
        get
        {
            var scrollView = GameObject.Find("Canvas").transform.Find("Painel_Pedidos");
            return scrollView.Find("Viewport").Find("Content") as RectTransform;
        }
    }

    /// <summary>
    /// Essa propriedade buscará todos os filhos de PainelPedido. Basicamente, pegará todos os pedidos (em relação a interface gráfica) que estiverem em progresso.
    /// </summary>
    public static List<GameObject> FilhosPainelPedido
    {
        get
        {
            var lista = new List<GameObject>();

            for (int i = 0; i < PainelPedido.childCount; i++)
            {
                var g = PainelPedido.GetChild(i).gameObject;
                lista.Add(g);
            }

            return lista;
        }
    }

}
