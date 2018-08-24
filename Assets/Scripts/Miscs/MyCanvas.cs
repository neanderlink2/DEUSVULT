﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public static class MyCanvas
{
    public static RectTransform MaoP1
    {
        get
        {
            var g = GameObject.Find("Canvas").transform.Find("MaoP1");
            return g.GetComponent<RectTransform>();
        }
    }

    public static Slider[] BarrasTarefa
    {
        get
        {
            var g = Resources.FindObjectsOfTypeAll<Slider>().Where(x => x.CompareTag("BarraTarefa")).ToArray();
            
            return g;
        }
    }

    public static Slider BarraFornalha
    {
        get
        {
            var g = GameObject.Find("CanvasWorld").transform.Find("BarraFornalha");
            return g.GetComponent<Slider>();
        }
    }

}
