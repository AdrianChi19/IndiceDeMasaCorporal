using Imc.Models;

Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona");
Console.WriteLine();

decimal peso = ReadDecimal("Proporcione el peso en kilogramos de la persona:");
string entrada;
bool entradaEsValida;
decimal estatura = ReadDecimal("Proporcione el peso en kilogramos de la persona:");

decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
var estadoNutricional = CalculadoraImc.EstadoNutricional(imc);

Console.WriteLine($"El indice de masa corporal de la persona es {imc:F4}");
Console.WriteLine($"El estado nutricional de la persona es {estadoNutricional}");

static decimal ReadDecimal(string indicacion)
{
    string entrada;
   bool entradaEsValida;
    decimal valor;

    do
    {
        Console.Write(indicacion);
        entrada = Console.ReadLine();
        entradaEsValida = decimal.TryParse(entrada, out valor);
        if (!entradaEsValida)

        {
            Console.WriteLine("Error: La entrada debe ser numerica.");
        }
    } while (!entradaEsValida);
    return valor;
}