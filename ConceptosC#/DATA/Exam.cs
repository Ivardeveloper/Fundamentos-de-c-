using System;

public class Exam 

{
    public int a;
    public int b;
    public int c;

    public Exam(int a, int b, int c=10)
    {
        this.a=a;
        this.b=b;
        
    }

    public void Sumar(int a, int b)
    {
        c = a+b;
        Console.WriteLine(c);


    }

}