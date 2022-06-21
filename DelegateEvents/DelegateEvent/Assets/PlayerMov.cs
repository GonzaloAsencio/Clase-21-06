using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float velocidad = 5;
   public Text MonedaText;
    int MonedaCont;
  
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MonedaText.text = "Monedas:" + MonedaCont.ToString();
        Caminar();
    }

    void Caminar()
    {
        var Movimiento_X = Input.GetAxisRaw("Horizontal");

        rb2d.velocity = new Vector2(Movimiento_X * velocidad, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        MonedaCont++;
    }
}
