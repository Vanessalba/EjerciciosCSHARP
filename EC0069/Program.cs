int[] arr = { 1, 2, 3, 4, 5 };
bool ascendente = true;

for (int i = 1; i < arr.Length; i++) {
    if (arr[i] <= arr[i - 1]) {
        ascendente = false;
        break;
    }
}

Console.WriteLine(ascendente ? "Está en orden ascendente" : "No está ordenado");