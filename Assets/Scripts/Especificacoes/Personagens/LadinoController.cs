using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class LadinoController : Personagem
{
    protected override void Start()
    {
        Vel *= 1.4f;
        base.Start();
    }
}
