Console.Write("Introduce un número: ");
int n = int.Parse(Console.ReadLine());
int positivo = n < 0 ? -n : n;
Console.WriteLine($"Versión positiva: {positivo}");