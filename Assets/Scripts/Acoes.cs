using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acoes : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InteragirGeladeira ()
    {
        Personagem p = player.GetComponent<Personagem>();

        if (p.alimentoNaMao == null)
        {
            Alimento a = ScriptableObject.CreateInstance<Alimento>();
            a.estadoAlimento = EstadoAlimento.EmPreparo;
            p.alimentoNaMao = a;
        }else
        {
            Debug.Log("Já tem um alimento na mão.");
        }
    }

    public void InteragirFogao ()
    {
        Personagem p = player.GetComponent<Personagem>();
        if (p.alimentoNaMao != null)
        {
            p.alimentoNaMao = null;
            Debug.Log("Colocou para cozinhar");
        }
        else
        {
            Debug.LogError("Não há alimento na mão");
        }
    } 
}
