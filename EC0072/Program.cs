Console.Write("Introduce una frase: ");
string frase = Console.ReadLine();
string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int contador = 0;

foreach (string p in palabras) {
    if (p.Length > 5) contador++;
}

Console.WriteLine($"Palabras con más de 5 caracteres: {contador}");