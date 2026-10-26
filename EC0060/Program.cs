int[] arr = { 1, 5, 2, 8 };
int sumaDiferencias = 0;
for (int i = 1; i < arr.Length; i++) {
    sumaDiferencias += Math.Abs(arr[i] - arr[i - 1]);
}
Console.WriteLine($"Suma de diferencias {sumaDiferencias}");