using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Delegate : MonoBehaviour
{
    delegate void Metodo();

    Metodo  Mimetodo;
    private void Start()
    {
       Mimetodo = Hola;
        Mimetodo();
     /*  Mimetodo -= Hola;
     
        if(Mimetodo!= null)
            Mimetodo();*/ 
      //  Mimetodo?.Invoke();
    }

    private void Hola()
    {
        Debug.Log("Hola");
    }

    private void Chau()
    {
        Debug.Log("Chau");
    }

}
