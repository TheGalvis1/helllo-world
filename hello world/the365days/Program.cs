using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var thepresent = DateTime.Now.Year;
    var message = string.Empty;
    var Year = consoleExtension.GetInt("Ingrese año: ");

    if (Year == thepresent)
    {
        message = "es";
    } else if (Year > thepresent)
    {
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }


    if (Year % 4 == 0)
    {
        if (Year % 100 == 0)
        {
            if (Year % 400 == 0)
            {
                Console.WriteLine($"El año: {Year}, Si {message} bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año: {Year}, No {message} bisiesto.");
            }
        }
        else
        {
            Console.WriteLine($"El año: {Year}, Si {message} bisiesto.");
        }
    }
    else
    {
        Console.WriteLine($"el año: {Year}, No {message} bisiesto.");
    }

    do
    {
        answer = consoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");
