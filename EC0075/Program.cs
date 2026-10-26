Console.Write("Número 1: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Número 2: ");
int n2 = int.Parse(Console.ReadLine());

int mayor = Math.Max(n1, n2);
int menor = Math.Min(n1, n2);

if (menor != 0 && mayor % menor == 0) {
    Console.WriteLine("El mayor es múltiplo del menor.");
} else {
    Console.WriteLine("No es múltiplo.");
}