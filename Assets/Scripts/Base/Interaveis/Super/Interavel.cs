using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Eventos : UnityEvent<string> { }

public abstract class Interavel : MonoBehaviour {

    public Eventos OnInteragiu;

    public Personagem Personagem { get; set; }



    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        
	}

    void OnTriggerStay (Collider other)
    {
        if (other.GetComponent<Personagem>() != null)
        {
            Personagem = other.GetComponent<Personagem>();
            if (Input.GetKeyDown(Personagem.botaoInteracao))
            {
                OnInteragiu.Invoke(null);
            }
        }
        
    }

}
