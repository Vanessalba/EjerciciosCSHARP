Console.Write("Introduce un carácter: ");
char c = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (c) {
    case >= '0' and <= '9':
        Console.WriteLine("Es un número.");
        break;
    case '.' or ',' or ';' or ':':
        Console.WriteLine("Es un signo de puntuación.");
        break;
    default:
        Console.WriteLine("Otro carácter.");
        break;
}