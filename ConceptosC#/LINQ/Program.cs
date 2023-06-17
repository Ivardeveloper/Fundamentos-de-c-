// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var beers = new List<Beer>()
{
    new Beer(){Nombre = "Modelo", Marca = "Corona", Alcohol = 5.0m},
    new Beer(){Nombre = "Tecate", Marca = "Moctezuma", Alcohol = 5.6m},
    new Beer(){Nombre = "Victoria", Marca = "Corona", Alcohol = 5.4m},
    new Beer(){Nombre = "Cucapa", Marca = "Cucapa", Alcohol = 5.3m},
    new Beer(){Nombre = "Stella", Marca = "Amber", Alcohol = 5.1m},


};


//consulta LINQ Select

var names = from b in beers 
            select b.Nombre;
            //colecciones anonimas, objetos anonimos, no requerimos de clases para crear los objetos, si no que estos 
            //se crean mediante linq, empleando la NEW

 
var exp1 = from b in beers            
            select new {b.Nombre, b.Marca};

 
var exp2 = from b in beers            
            where b.Marca == "Corona" || b.Alcohol >= 5
            select new {b.Nombre, b.Marca};   

//encadenamiento de metodos
var exp3 = beers.Where(b => b.Marca == "Moctezuma" || b.Alcohol >=6)
                .Select(b => new 
                {
                    b.Nombre,
                    b.Marca

                });

                    


foreach(var Nombre in names)
{
    Console.WriteLine(Nombre);

}  
Console.WriteLine("Aqui, es otro ejemplo 1 ---------------");   

foreach(var b in exp1)
{
    Console.WriteLine(b.Marca);

} 
Console.WriteLine("Aqui, es otro ejemplo 2---------------");

foreach(var b in exp2)
{
    Console.WriteLine(b.Nombre);

} 

Console.WriteLine("Aqui, es otro ejemplo 3---------------");

foreach(var b in exp3)
{
    Console.WriteLine(b.Nombre);

} 


public class Beer
{
    public string Nombre { get; set; }

    public string Marca { get; set; }

    public decimal Alcohol { get; set; }


}
