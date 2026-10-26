int n;
do {
    Console.Write("Introduce un número: ");
    n = int.Parse(Console.ReadLine());
} while (!(n % 2 == 0 && n % 3 == 0 && n % 7 == 0));

Console.WriteLine("¡Correcto! Es múltiplo de 2, 3 y 7.");