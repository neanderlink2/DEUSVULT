using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Eventos : UnityEvent<string> { }

public abstract class Interavel : MonoBehaviour {

    public Eventos OnInterou;

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        OnInterou.Invoke(null);
    }

}
