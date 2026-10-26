Console.Write("Introduce el texto: ");
string texto = Console.ReadLine();

Console.Write("Introduce el desplazamiento (número): ");
int desplazamiento = int.Parse(Console.ReadLine());

string resultado = "";

// Recorremos cada letra de la frase una a una
foreach (char c in texto) {
    
    // Si es una letra minúscula (de la 'a' a la 'z')
    if (c >= 'a' && c <= 'z') {
        // Convertimos la letra en una posición del 0 al 25 ('a' es 0, 'b' es 1...)
        int posicionActual = c - 'a';
        
        // Sumamos el desplazamiento. El '%' (resto) de 26 sirve para que, 
        // si nos pasamos de la 'z', dé la vuelta y empiece otra vez por la 'a'.
        int nuevaPosicion = (posicionActual + desplazamiento) % 26;
        
        // Volvemos a transformar ese número en letra sumándole 'a'
        char nuevaLetra = (char)('a' + nuevaPosicion);
        resultado += nuevaLetra;
    }
    
    //  Si es una letra mayúscula (de la 'A' a la 'Z')
    else if (c >= 'A' && c <= 'Z') {
        int posicionActual = c - 'A';
        int nuevaPosicion = (posicionActual + desplazamiento) % 26;
        char nuevaLetra = (char)('A' + nuevaPosicion);
        resultado += nuevaLetra;
    }
    
    //  Si es un espacio, un punto o un número, lo dejamos tal cual
    else {
        resultado += c;
    }
}

Console.WriteLine($"Texto cifrado: {resultado}");