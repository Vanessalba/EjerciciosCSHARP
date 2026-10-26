Console.Write("Introduce el primer número: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Introduce el segundo número: ");
int num2 = int.Parse(Console.ReadLine());

int numeros = num1 / num2;
int resto = num1 % num2;

Console.WriteLine($"Resultado de la división: {numeros}");
Console.WriteLine($"Resto de la división: {resto}");