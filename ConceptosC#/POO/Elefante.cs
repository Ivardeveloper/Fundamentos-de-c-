using System;

public class Elefante : Omnivoro

{
    public string PesoElefante { get; set; }

    public string TipoElefante { get; set; }


    public void Correr(int velElefante)
    {
        Console.WriteLine("El eefante corre a una velocidad de:" + velElefante);
    }



}