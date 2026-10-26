int a = 3;
int b = ++a; // a vale 4, b vale 4
int c = a++; // c vale 4, a pasa a 5
b = b * 3;   // b vale 12
a = a * 2;   // a vale 10
Console.WriteLine($"a = {a}, b = {b}, c = {c}");