using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Moneda : MonoBehaviour
{
    public delegate void MonedaEvent();
    public static MonedaEvent monedaEvent;
    // public static event Action monedaEvent;  // con Encapsulamiento
    private void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            monedaEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
