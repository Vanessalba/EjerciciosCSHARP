Console.Write("Número 1 (byte): ");
byte n1 = byte.Parse(Console.ReadLine());
Console.Write("Número 2 (byte): ");
byte n2 = byte.Parse(Console.ReadLine());

ushort resultado = (ushort)(n1 * n2);
Console.WriteLine($"Resultado en ushort: {resultado}");