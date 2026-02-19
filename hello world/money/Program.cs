using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = consoleExtension.GetString("ingrese nombre:");
    var workHours = consoleExtension.GetFloat("ingrese horas trabajadas:");
    var hourValue = consoleExtension.GetDecimal("ingrese valor de la hora:");
    var salaryMinimun  = consoleExtension.GetDecimal("ingrese salario minimo mensual:");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre:........{name}");
        Console.WriteLine($"Salario:.........{salaryMinimun:C2}");


    }
    else
    {
        Console.WriteLine($"Nombre:.........{name}");
        Console.WriteLine($"Salario:..........{salary:C2}");
    }


    do
    {
        answer = consoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over");