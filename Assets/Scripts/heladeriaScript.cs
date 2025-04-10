using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heladeriaScript : MonoBehaviour
{
    public string gusto;
    public float peso;
    float precio;
    // Start is called before the first frame update
    void Start()
    {
        if (peso >= 250 && peso <= 3000)
        {
            if (gusto == "FRU")
            {
                precio = (((peso / 1000) * 500) / 100) * 90;

            }
            else if (gusto == "CHO" || gusto == "DDL")
            {
                precio = (peso / 1000) * 500;

            }


            else
            {
                Debug.Log("El valor ingresado para gusto no es válido");
                return;
            }
            Debug.Log("El precio de " + peso + " gramos de " + gusto + " es " + precio);
        }
        else
        {
            Debug.Log("El valor ingresado para peso no es válido");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
