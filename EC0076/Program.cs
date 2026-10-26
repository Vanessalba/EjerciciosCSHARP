Console.Write("Introduce un número (0-9): ");
int n = int.Parse(Console.ReadLine());
string[] letras = { "Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve" };

if (n >= 0 && n <= 9) {
    Console.WriteLine(letras[n]);
} else {
    Console.WriteLine("Fuera de rango.");
}