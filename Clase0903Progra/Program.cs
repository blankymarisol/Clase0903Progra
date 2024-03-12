 // ejercicio de adivinar el numero
static void juego()
{
    Console.WriteLine("Piensa en un numero para empezar el juego.");
    Thread.Sleep(5000);

    Console.WriteLine("Sigue los pasos y adivinare tu numero pensado.");
    Thread.Sleep(5000);

    Console.WriteLine("Tu numero multiplicalo por 2. ");
    Thread.Sleep(5000);

    Console.WriteLine("Tu numero multiplicalo por 5. ");
    Thread.Sleep(5000);

    Console.WriteLine("ahora sumale 8.");
    Thread.Sleep(5000);

    Console.WriteLine("ahora escribe tu resultado.");
    Thread.Sleep(5000);

    int numero = (Convert.ToInt32(Console.ReadLine()));
    string numeroLetra = numero.ToString();
    string resultado = numeroLetra.Substring(0, numeroLetra.Length - 1);
    Console.WriteLine("Tu numero es :  " + resultado);
}
juego();



// ejercicio del numero maximo y minimo
static void Maximo()
{
    int num, max = int.MinValue, min = int.MaxValue;
    do
    {
        Console.WriteLine("ingrese su numero");
        num = Convert.ToInt32(Console.ReadLine());

        if (num != 0)
        {
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }
    }

    while (num != 0);


    Console.WriteLine("El número máximo es: " + max);
    Console.WriteLine("El número mínimo es: " + min);
}
Maximo();



//ejercicio contador de palabras
static void Contador()
{
    Console.WriteLine("Ingresa la frase que deseas contar");
    string frase = Console.ReadLine();

    int contadorpalabra = 0;
    int contadorvocales = 0;
    int i = 0;

    while (i < frase.Length)
    {
        while (i < frase.Length && frase[i] == ' ')
        {
            i++;
        }
        if (i < frase.Length)
        {
            contadorpalabra++;

            foreach (char a in frase.ToLower())
            {
                if (EsVocal(a))
                {
                    contadorvocales++;
                }
            }

            while (i < frase.Length && frase[i] != ' ')
            {
                i++;
            }
        }

    }
    Console.WriteLine("El numero de palabras es: " + contadorpalabra);
    Console.WriteLine("El numero de vocales es: " + contadorvocales);

    static bool EsVocal(char a)
    {
        return "aeiouáéíóú".Contains(a);
    }
}

Contador();



static void Palindromos()  //ejercicio de palindromos
{
    Console.WriteLine("Ingrese una frase para verificar si es palindroma");
    string frase = Console.ReadLine();

    frase = frase.Replace(" ", " ").ToLower();

    bool esPalindromo = false;

    for (int i = 0; i < frase.Length / 2; i++)
    {
        if (frase[i] != frase[frase.Length - i - 1])
        {
            esPalindromo = true; break;
        }
    }
    if (esPalindromo)
    {
        Console.WriteLine("La frase es un palindromo");
    }
    else
    {
        Console.WriteLine("La frase no es un palindromo");
    }
}

Palindromos();