string[] nombres = new string[5];
for (int i = 0; i < 5; i++) {
    Console.Write($"Nombre {i + 1}: ");
    nombres[i] = Console.ReadLine();
}

Console.WriteLine("\nNombres sin 'a':");
foreach (string nom in nombres) {
    if (!nom.Contains('a') && !nom.Contains('A')) {
        Console.WriteLine(nom);
    }
}