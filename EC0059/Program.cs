using System;
class Program {
    static void Main() {
        Console.Write("Precio sin IVA: ");
        double precioSinIva = double.Parse(Console.ReadLine());
        double precioConIva = precioSinIva * 1.21;
        Console.WriteLine($"Precio con IVA: {precioConIva}");
    }
}