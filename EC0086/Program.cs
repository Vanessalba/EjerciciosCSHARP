Console.Write("¿Cuántos caracteres?: ");
int n = int.Parse(Console.ReadLine());
char[] chars = new char[n];

for (int i = 0; i < n; i++) {
    chars[i] = Console.ReadKey().KeyChar;
}
Console.WriteLine();

Array.Reverse(chars);
Console.WriteLine(new string(chars));