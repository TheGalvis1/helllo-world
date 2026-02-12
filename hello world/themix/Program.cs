using Shared;

do
{
    Console.WriteLine("Ingrese 3 números diferentes");
    var a = consoleExtension.GetInt("Ingrese primer número:");
    var b = consoleExtension.GetInt("Ingrese segundo número:");
    if (a == b)
    {
        Console.WriteLine("Deben ser números diferentes, vuelvelo a intentar...");
        continue;
    }
    var c = consoleExtension.GetInt("Ingrese tercer número:");
    if (b == c || c == a)
    {
        Console.WriteLine("Deben ser números diferentes, vuelvelo a intentar...");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mañor es {a}, el medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mañor es {a}, el medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mañor es {b}, el medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mañor es {b}, el medio es {c}, el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mañor es {c}, el medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mañor es {c}, el medio es {b}, el menor es {a}");
        }
    }


} while (true);