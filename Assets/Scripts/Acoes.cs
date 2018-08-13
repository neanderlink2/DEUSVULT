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

    public void InteragirFogao (GameObject fogao)
    {
        Personagem p = player.GetComponent<Personagem>();
        if (p.alimentoNaMao != null)
        {
            if (fogao.GetComponent<Fogao>().alimento == null)
            {
                if (fogao.GetComponent<Fogao>().isCozinhando)
                {
                    p.alimentoNaMao = fogao.GetComponent<Fogao>().RetirarObjetoGuardado();
                    StopCoroutine(fogao.GetComponent<Fogao>().Cozinhar());
                    Debug.Log("Retirou alimento");
                }
                else
                {
                    fogao.GetComponent<Fogao>().GuardarObjeto(p.alimentoNaMao);
                    p.alimentoNaMao = null;
                    StartCoroutine(fogao.GetComponent<Fogao>().Cozinhar());
                    Debug.Log("Retirou alimento");
                }
            }
        }
        else if (fogao.GetComponent<Fogao>().alimento != null)
        {
            p.alimentoNaMao = fogao.GetComponent<Fogao>().RetirarObjetoGuardado();
            Debug.Log("Retirou alimento");

        }
        else
        {
            Debug.LogError("Não há alimento na mão");

        }
    } 

    

}
