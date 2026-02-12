using Shared;

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
                Console.WriteLine($"El año: {Year}, Si {message} biciesto.");
            }
            else
            {
                Console.WriteLine($"El año: {Year}, No {message} biciesto.");
            }
        }
        else
        {
            Console.WriteLine($"El año: {Year}, Si {message} biciesto.");
        }
    }
    else
    {
        Console.WriteLine($"el año: {Year}, No {message} biciesto.");
    }
} while (true);