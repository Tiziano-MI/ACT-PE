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

        //EJERCICIO 2: Crear numeros randoms entre -100 y 100
        int numero1 = Random.Range(-100, 100);
        int numero2 = Random.Range(-100, 100);
        int numero3 = Random.Range(-100, 100);

        //EJERCICIO 2: Ejecuta la función y muestra el resultado
        Debug.Log(numero1);
        Debug.Log(numero2);
        Debug.Log(numero3);
    }

    private int[] numeros = { 97, -64, -3, -58, -15, 58, 51, 38, -31, -37 };


    //EJERCICIO 3: Variable para medir el tiempo
    private float timer = 0;


    private void Update()
    {
        //EJERCICIO 3: Suma mas tiempo al timer
        timer += Time.deltaTime;

        //EJERCICIO 3: Cuando hayan pasado el tiempo establecido, se hara el nuevo array
        if(timer >= 4.5) NuevoArray();
    }


    private void NuevoArray()
    {
        //EJERCICIO 3: Duplica los pares del array
        for(int a = 0; a < numeros.Length; a++)
        if (numeros[a] % 2 == 0) numeros[a] *= 2;

        Debug.Log("Array nuevo: " + string.Join(", ", numeros));

        //EJERCICIO 3: Desactiva el script después del nuevo array
        this.enabled = false;
    }
}