using UnityEngine;

public class ForjaController : Aperfeicoador
{

    protected override void OnTriggerStay(Collider collider)
    {
        if (Personagem is BarbaroController)
        {
            tempoAdd = 3;
        }
        else
        {
            tempoAdd = 1;
        }
        
        base.OnTriggerStay(collider);
    }

}
