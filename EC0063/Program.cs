int[] arr = { 1, 0, 2, 0, 3 };
int cuentaNoCeros = 0;

foreach (int n in arr) {
    if (n != 0) cuentaNoCeros++;
}

int[] compactado = new int[cuentaNoCeros];
int idx = 0;
foreach (int n in arr) {
    if (n != 0) {
        compactado[idx] = n;
        idx++;
    }
}

Console.WriteLine($"Array sin ceros: {string.Join(", ", compactado)}");