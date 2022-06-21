using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    delegate int Calcular(int a, int b);
    delegate string NombreCompleto(string nombre, string apellido);
    
    Calcular Método;
 
    private void Start()
    {
        Método += Suma;
        Debug.Log("La suma es:" + Método(2,2));
        // Debug.Log("La suma es:" + Método?.Invoke(2,2));

    }

    int Suma(int a, int b)
    {
        return a + b;
    }
    int Resta(int a, int b)
    {
        return a - b;
    }
}
