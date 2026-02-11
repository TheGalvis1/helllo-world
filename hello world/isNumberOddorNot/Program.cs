var numberString = string.Empty;
do
{
    Console.Write ("Ingrese número entero o la palabra 'Salir' para salir:");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "Salir") 
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.Write($"El numero {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt}, es impar.");
        }
    }
    else
    {
        Console.Write($"los que ingresaste: {numberInt}, no es un número entero.");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");
