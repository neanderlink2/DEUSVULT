using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class Extensions
{
    public static Personagem GetPersonagem(this Transform obj)
    {
        return GameObject.FindWithTag("Player").GetComponent<Personagem>();
    }
}
