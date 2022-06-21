using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaManager : MonoBehaviour
{
    public Text Monedatext;
    private int Contador;

    void MonedaText()
    {
        Contador++;
        Monedatext.text = "MONEDAS:" + Contador;
    }

    private void OnEnable()
    {
        Moneda.monedaEvent += MonedaText;
    }

    private void OnDisable()
    {
        Moneda.monedaEvent -= MonedaText;
    }
}
