int[] arr = { 5, 1, 9, 3 };
int min = arr[0], max = arr[0], suma = 0;

foreach (int n in arr) {
    if (n < min) min = n;
    if (n > max) max = n;
    suma += n;
}

double media = (double)(suma - min - max) / (arr.Length - 2);
Console.WriteLine($"Media sin el mínimo y el máximo: {media}");