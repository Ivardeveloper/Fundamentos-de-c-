using System;
using System.Collections;

//ejemplos de C#, tipos de datos
//ejemplo de arrays


namespace MyApplication
{
  public class Program
  {
    static void Main(string[] args)
    {
// ejemplos de arreglos, al arreglo se le da una longitud inicial,  el arreglo es mas rapido, esta orientado a colecciones
        int[] numeros = new int[5] {1,2,3,4,5};

        for (int i=0; i<numeros.Length; i++)
        {

            Console.WriteLine(numeros[i]);
        
        }

        //foreach

        foreach (var numero in numeros)
        {

            Console.WriteLine(numero);

        }

        // Listas
        Console.WriteLine("Espacio aqui para las listas **");
        List<int> lista = new List<int>() {1,2,3,4,5,6,};

        lista.Add(1);
        lista.Add(8);
        foreach (var num in lista)
        {
            Console.WriteLine("elemento"+num);
        }



    }
  }
}
