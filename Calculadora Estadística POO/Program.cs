// See https://aka.ms/new-console-template for more information

using Calculadora_Estadística_POO;
List <double> NumbersList = new List<double>();
ListaNumeros calculations = new ListaNumeros(NumbersList);

bool continueOne = true;
do
{
    try
    {
        Console.Clear();
        calculations.ShowMenu();
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                calculations.EnterNumbersList();
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("--- Calcular y Mostrar la Media ---");
                Console.WriteLine($"La media es: {calculations.CalculateAverage()}");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("--- Calcular y Mostrar la Mediana ---");
                Console.WriteLine($"La mediana es: {calculations.CalculateMedian()}");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("--- Calcular y Mostrar la Moda ---");
                Console.WriteLine($"La moda es: {calculations.CalculateMode()}");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("--- Calcular y Mostrar la Desviación Estándar ---");
                Console.WriteLine($"La desviación estándar es: {calculations.CalculateStandarDeviation()}");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
            case 6:
                Console.Clear();
                calculations.EnterNumbersList();
                break;
            case 7:
                Console.WriteLine("\nUsted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                continueOne = false;
                break;
            default:
                Console.WriteLine("\nIngrese una opción válida");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine();
        Console.WriteLine("Error: Por favor ingrese una opción numérica");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadKey();
    }
} while (continueOne);