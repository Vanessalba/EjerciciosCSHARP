int[] arr = { -2, 0, 5, 3, -1 };
int suma = 0;

foreach (int x in arr) {
    if (x > 0) suma += x;
}

Console.WriteLine($"Suma de positivos: {suma}");