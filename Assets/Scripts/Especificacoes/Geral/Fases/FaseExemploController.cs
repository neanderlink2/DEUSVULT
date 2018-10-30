using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaseExemploController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 0;
        MessageController.Show("Essa será sua primeira missão. Você deverá transformar as cotas de malha recebidas em armaduras de bronze. " +
            "\nVocê terá dois personagens a sua disposição. Tente jogar com um amigo! Os controles são:\n" +
            "Player 1: \n\tSetas - Movimentação\n\tEnter - Interage com os objetos na cena.\n\tEste personagem é mais rápido, porém é mais demorado quando aperfeiçoa um objeto." +
            "\nPlayer 2: \n\tWASD - Movimentação\n\tF - Interage com os objetos na cena.\n\tEste personagem é o mais equilibrado, com todos os status na medida certa.",
            "Próximo", () =>
            {
                MessageController.Show("\nExistem outros tipos de interáveis na cena." +
                            "\n\tBancada (Azul): Guarda um objeto até que algum jogador o pegue. Para combinar objetos, coloque os dois objetos na bancada." +
                            "\n\tForja (Preto): Modela uma armadura para que possa adicionar a barra de bronze derretida." +
                            "\n\tLixeira (Amarelo): Joga fora o objeto que está na mão do jogador.", "Próximo", () =>
                            {
                                MessageController.Show("Para criar uma Armadura de Bronze, você deve combinar uma Cota de Malha, que esteja concertada, e adicionar Bronze Derretido sobre ela." +
                                    "\nUse o Combinador para juntar os objetos.");
                                Camera.main.GetComponent<PedidoController>().enabled = true;
                                //MyCanvas.Mensagem.transform.parent.gameObject.SetActive(false);
                                Time.timeScale = 1;
                            });
            });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
