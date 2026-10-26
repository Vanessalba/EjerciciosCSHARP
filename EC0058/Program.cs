Console.Write("Introduce un número ");
int numero = int.Parse(Console.ReadLine());
int ultimoDigito = Math.Abs(numero) % 10;
Console.WriteLine($"El último dígito es: {ultimoDigito}");