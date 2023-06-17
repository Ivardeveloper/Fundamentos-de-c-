using System;

namespace POO;
public class Program
{
    static void Main(string[] args)
    {
        Tigre oTigre = new Tigre();
        oTigre.Correr(56);
      

        Aguila oAguila = new Aguila();
        oAguila.Volar();
        oAguila.Nombre="condor";

        Elefante oElefante = new Elefante();
        oElefante.Correr(70);


    }
}
