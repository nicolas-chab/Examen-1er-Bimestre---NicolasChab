using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recuperatorio : MonoBehaviour
{
    public string animal;
    public int dias;
    // Start is called before the first frame update
   
    int precio;
    int pesoG;
    int pesoPP;
    int pesoPG;
    void Start()
    {
        if(animal!="G" && animal != "PP" && animal != "PG")
        {
            Debug.Log("Ingrese un codigo valido");
        }
        if (dias<3)
        {
            Debug.Log("la cantidad de dias debe ser 3 o mas");
        }
        else
        {
            if (animal == "G")
            {
                pesoG = 300 * dias;

                Debug.Log("Para ese período se necesitan  " + pesoG + " gramos de alimento");
            }
            if (animal == "PP")
            {
                pesoPP = 400 * dias;

                Debug.Log("Para ese período se necesitan  " + pesoPP + " gramos de alimento");
            }
            if (animal == "PG")
            {
                pesoPG = 700 * dias;

                Debug.Log("Para ese período se necesitan  " + pesoPG + " gramos de alimento");
            }
 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
