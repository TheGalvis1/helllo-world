using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("ingrese 3 numero diferentes");
    var a = consoleExtension.GetInt("Ingrese primer numero:");
    var b = consoleExtension.GetInt("Ingrese segundo numero:");
    var c = consoleExtension.GetInt("Ingrese tercer numero:");

    if (a > b && a > c)
    {
        Console.WriteLine($"El numero mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero mayor es: {b}");
    }
    else
    { 
        Console.WriteLine($"El numero mayor es: {c}");
    }

    do
    {
        answer = consoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");