using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public static class Extensions
{

    public static bool IsIgual (this float num1, float num2)
    {
        if (num1 >= num2-0.1f && num1 <= num2+0.1f)
        {
            return true;
        }
        return false;
    }

}
