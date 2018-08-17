using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Eventos : UnityEvent<string> { }

public abstract class Interavel : MonoBehaviour {

    public Eventos OnInteragiu;

    protected Personagem personagem;

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        
	}

    void OnTriggerStay (Collider other)
    {
        if (Input.GetKeyDown(transform.GetPersonagem().botaoInteracao))
        {
            OnInteragiu.Invoke(null);
        }
    }

}
