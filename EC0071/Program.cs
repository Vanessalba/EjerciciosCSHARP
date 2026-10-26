int[] arr = { 1, 7, 3, 10, 4 };
int maxDiff = 0;

for (int i = 1; i < arr.Length; i++) {
    int diff = Math.Abs(arr[i] - arr[i - 1]);
    if (diff > maxDiff) maxDiff = diff;
}

Console.WriteLine($"Máxima diferencia: {maxDiff}");