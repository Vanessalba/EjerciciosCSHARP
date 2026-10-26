Random rnd = new Random();
int secreto = rnd.Next(1, 101);
int intento;

do {
    Console.Write("Adivina (1-100): ");
    intento = int.Parse(Console.ReadLine());
    if (intento < secreto) Console.WriteLine("Es mayor.");
    else if (intento > secreto) Console.WriteLine("Es menor.");
} while (intento != secreto);

Console.WriteLine("¡Acertaste!");