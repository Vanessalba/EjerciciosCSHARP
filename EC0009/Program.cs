using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una distancia en metros: ");
        double metros = Convert.ToDouble(Console.ReadLine());

        

        double millas = metros / 1609;

        Console.WriteLine("Distancia en millas: " + millas);
    }
}
