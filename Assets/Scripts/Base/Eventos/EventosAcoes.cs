using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAcoes : MonoBehaviour
{
    public void InteragirFonte(GameObject fonte)
    {
        fonte.GetComponent<Fonte>().PegarObjeto();
    }

    public void InteragirManipulador(GameObject manipulador)
    {
        Manipulador m = manipulador.GetComponent<Manipulador>();
        m.Manipulacao();
    }


    public void InteragirReceptor(GameObject receptor)
    {        
        receptor.GetComponent<Receptor>().EntregarObjeto();
    }

    public void InteragirAperfeicoador (GameObject aperfeicoador)
    {
        aperfeicoador.GetComponent<Aperfeicoador>().Aperfeicoar();        
        
    }
}
