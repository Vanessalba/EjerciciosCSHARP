using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Ingrese el primer entero (a): ");
        int a = int.Parse(Console.ReadLine());

      
        Console.Write("Ingrese el segundo entero (b): ");
        int b = int.Parse(Console.ReadLine());

        
        int resultado = a + b;

        Console.WriteLine($"{a} + {b} = {resultado}");
    }
}