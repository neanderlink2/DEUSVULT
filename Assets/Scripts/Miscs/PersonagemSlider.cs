using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;

public class PersonagemSlider : MonoBehaviour {

    public Personagem perso;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        try
        {
            Vector3 v = new Vector3(perso.gameObject.transform.position.x, transform.position.y, perso.gameObject.transform.position.z + 1);
            transform.position = v;
        }
        catch (System.Exception)
        {

        }
        
	}

}
