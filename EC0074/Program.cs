int[] array = new int[100];
int contador = 0;
int op;

do {

    Console.WriteLine("1. Agregar número");
    Console.WriteLine("2. Listar");
    Console.WriteLine("3. Mostrar promedio");
    Console.WriteLine("4. Salir");
    Console.Write("Elige opción: ");
    op = int.Parse(Console.ReadLine());

    switch (op) {
        case 1:
            if (contador < 100) {
                Console.Write("Número: ");
                array[contador++] = int.Parse(Console.ReadLine());
            } else {
                Console.WriteLine("Array lleno.");
            }
            break;
        case 2:
            Console.WriteLine(string.Join(", ", array[..contador]));
            break;
        case 3:
            if (contador > 0) {
                double s = 0;
                for (int i = 0; i < contador; i++) s += array[i];
                Console.WriteLine($"Promedio: {s / contador}");
            } else {
                Console.WriteLine("No hay datos.");
            }
            break;
    }
} while (op != 4);