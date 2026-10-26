Console.Write("Introduce un nombre con espacios y desordenado: ");
string nombre = Console.ReadLine().Trim().ToLower();

if (nombre.Length > 0) {
    nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);
}

Console.WriteLine($"Nombre limpio: '{nombre}'");