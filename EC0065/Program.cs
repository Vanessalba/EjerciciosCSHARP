int[] a = { 1, 2, 3 };
int[] b = { 4, 5, 6 };
int productoEscalar = 0;

for (int i = 0; i < a.Length; i++) {
    productoEscalar += a[i] * b[i];
}

Console.WriteLine($"Producto escalar: {productoEscalar}");