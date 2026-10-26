int[] arr = { 5, 1, 9, 3, 9 };
int max = int.MinValue;
int segundo = int.MinValue;

foreach (int n in arr) {
    if (n > max) {
        segundo = max;
        max = n;
    } else if (n > segundo && n < max) {
        segundo = n;
    }
}
Console.WriteLine($"El segundo mayor valor es: {segundo}");