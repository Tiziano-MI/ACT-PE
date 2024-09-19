using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticaDos : MonoBehaviour
{
    //EJERCICIO 1: Función que recibe tres numeros
    public string ComprobacionDeNumeros(int numero1, int numero2, int numero3)
    {
        //EJERCICIO 1: Encontrar el mayor y el menor de los tres numeros
        int mayor = Mathf.Max(numero1, numero2, numero3);
        int menor = Mathf.Min(numero1, numero2, numero3);

        //EJERCICIO 1: Probar que las condiciones se cumplan
        if (mayor > 100)
        return "Mayor fuera de rango";
        if (menor < 0)
        return "Menor fuera de rango";

        //EJERCICIO 1:Calculo para devolver el promedio
        int promedio = (numero1 + numero2 + numero3) / 3;
        return "El valor promedio es: " + promedio;
    }

    private void Start()
    {
        //EJERCICIO 1:Texteo de la funcion
        Debug.Log(ComprobacionDeNumeros(30, 45, 180));
        Debug.Log(ComprobacionDeNumeros(68, -20, 73));
        Debug.Log(ComprobacionDeNumeros(25, 25, 25));
    }
}
