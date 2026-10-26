Console.Write("Introduce cantidad en euros: ");
int cantidad = int.Parse(Console.ReadLine());
int[] valores = { 200, 100, 50, 20, 10, 5, 2, 1 };

foreach (int v in valores) {
    int count = cantidad / v;
    if (count > 0) {
        Console.WriteLine($"{count} de {v}€");
        cantidad %= v;
    }
}