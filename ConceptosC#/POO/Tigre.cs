

public class Tigre : Carnivoro
{
    public string ColorPelo { get; set; }

    public string  NoLeonas { get; set; }

    private int velocidadLeon = 30;



    public override string getNombre()
    {
        return "hola: " + Nombre;

    }

     public void Correr(string name, string ColorPelos)
    {
        Console.WriteLine("El tigre corre ha 1000 metros por hora y se llama" + name +"y su color de pelo es:" + ColorPelos);
        
    }

      public void Correr(int velleon)
    {
        Console.WriteLine("El tigre corre ha: "+ velleon + "metros por hora y se llama");
        
    }

   
}