Console.Write("Introduce una frase: ");
string frase = Console.ReadLine().ToLower();
int a = 0, e = 0, i = 0, o = 0, u = 0;

foreach (char c in frase) {
    if (c == 'a') a++;
    else if (c == 'e') e++;
    else if (c == 'i') i++;
    else if (c == 'o') o++;
    else if (c == 'u') u++;
}

Console.WriteLine($"Vocales -> a: {a}, e: {e}, i: {i}, o: {o}, u: {u}");