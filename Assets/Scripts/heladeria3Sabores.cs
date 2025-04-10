using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeria3Sabores : MonoBehaviour
{
    public int cantidadHelado;
    public string gustoHelado;
    float precio;
    // Start is called before the first frame update
    void Start()
    {
       if (cantidadHelado < 250)
        {
            Debug.Log("La cantidad de helado es menor a la permitida");
            return;
        }
       else if (cantidadHelado > 3000)
        {
            Debug.Log("La cantidad de helado es mayor a la permitida");
            return ;
        }
       if (gustoHelado == "FRU")
        {
            precio = cantidadHelado / 1000f * 500 * 0.9f;
        }
       else if(gustoHelado == "CHO")
        {
            precio = cantidadHelado / 1000f * 500;
        }
       else if(gustoHelado == "DDL")
        {
            precio = cantidadHelado / 1000f * 500;
        }
       else
        {
            Debug.Log("El gusto de helado no es valido");
            return;
        }
       Debug.Log("El precio de su pedido son $" +  precio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
