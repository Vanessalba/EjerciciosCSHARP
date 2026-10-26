int[] a = { 1, 2, 3 };
int[] b = { 4, 5, 6 };
int[] c = new int[a.Length + b.Length];
int j = 0;

for (int i = 0; i < a.Length; i++) {
    c[j++] = a[i];
    c[j++] = b[i];
}

Console.WriteLine($"Array intercalado: {string.Join(", ", c)}");