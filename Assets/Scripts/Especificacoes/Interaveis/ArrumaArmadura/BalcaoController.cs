using System.Collections;
using UnityEngine;

public class BalcaoController : Fonte {

    public override void Awake()
    {
        base.Awake();
        StartCoroutine(CriarPedidos());
    }

    public IEnumerator CriarPedidos ()
    {
        for (int i = 0; i < 5; i++)
        {
            objetos.Add(Instantiate(Resources.Load<Armadura>("ArmaduraBronze")));
            yield return new WaitForSeconds(15f);
        }
    }
}
