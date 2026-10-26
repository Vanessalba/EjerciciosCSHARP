Console.Write("Rojo (0-255): ");
int r = int.Parse(Console.ReadLine());
Console.Write("Verde (0-255): ");
int g = int.Parse(Console.ReadLine());
Console.Write("Azul (0-255): ");
int b = int.Parse(Console.ReadLine());

int rgb = (r << 16) | (g << 8) | b;
Console.WriteLine($"Hexadecimal: #{rgb:X6}");