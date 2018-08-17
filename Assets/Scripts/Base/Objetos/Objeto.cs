using UnityEngine;

[CreateAssetMenu(fileName = "Alimento", menuName = "Objetos/Alimento")]
public class Objeto : ScriptableObject {

    public string nome;
    public EstadoObjeto estadoObj;
    public float tempoParaFicarPronto;
    public float tempoDecorrido;
}
