using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
    delegate int Calcular(int a, int b);
    delegate string NombreCompleto(string nombre, string apellido);
    
    Calcular M�todo;
 
    private void Start()
    {
        M�todo += Suma;
        Debug.Log("La suma es:" + M�todo(2,2));
        // Debug.Log("La suma es:" + M�todo?.Invoke(2,2));

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
