Console.Write("Introduce un entero: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
n = Math.Abs(n);

while (n > 0) {
    suma += n % 10;
    n /= 10;
}

Console.WriteLine($"Suma de los dígitos: {suma}");