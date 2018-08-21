using UnityEngine;

[CreateAssetMenu(fileName = "Alimento", menuName = "Objetos/Objeto base")]
public class Objeto : ScriptableObject {

    public string nome;
    public EstadoObjeto estadoObj;
    public float tempoParaFicarPronto;
    public float tempoDecorrido;
    
}
