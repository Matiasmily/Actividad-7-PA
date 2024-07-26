// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

class Program 
{
    
    static void Main(string[] args)
    {
        List<double> enterNumbers = new List<double>();
        bool continueOne = true;
        do
        {
            try
            {
                Console.Clear();
                ShowMenu();
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                         NumbersList(enterNumbers);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- Calcular y Mostrar la Media ---");
                        Console.WriteLine($"La media es: {CalculateAverage(enterNumbers)}");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- Calcular y Mostrar la Mediana ---");
                        Console.WriteLine($"La mediana es: {CalculateMedian(enterNumbers)}");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("--- Calcular y Mostrar la Moda ---");
                        Console.WriteLine($"La moda es: {CalculateMode(enterNumbers)}");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("--- Calcular y Mostrar la Desviación Estándar ---");
                        Console.WriteLine($"La desviación estándar es: {CalculateStandarDeviation(enterNumbers)}");
                        Console.WriteLine("Presione Enter para continuar");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        NumbersList(enterNumbers);
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
        

    }
    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("----- CALCULADORA ESTADÍSTICA -----");
        Console.WriteLine(" -- MENÚ ---");
        Console.WriteLine("1. Ingresar números");
        Console.WriteLine("2. Calcular y mostrar la media");
        Console.WriteLine("3. Calcular y mostrar la mediana");
        Console.WriteLine("4. Calcular y mostrar la moda");
        Console.WriteLine("5. Calcular y mostrar la desviación estándar");
        Console.WriteLine("6. Volver a ingresar números");
        Console.WriteLine("7. Salir");
        Console.Write("Ingrese una opción: ");
    }
    static void NumbersList(List<double> listNumbers)
    {
       
            Console.Clear();
            listNumbers.Clear();
            Console.WriteLine("--- Ingresar números ---");
            Console.Write("¿Cuántos números desea ingresar?: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ingrese el No.{i + 1}: ");
                double number = double.Parse(Console.ReadLine());
                listNumbers.Add(number);

            }
            Console.WriteLine("\nHa ingresado los números correctamente");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            
       
    }

    static double CalculateAverage(List<double> listNumbers)
    {
        double average = 0, addition = 0; 
        foreach (double number in listNumbers)
        {
            addition += number;
        }
        average = addition / listNumbers.Count();
        return average;
    }
    static double CalculateMedian(List<double> listNumbers)
    {
        double median = 0;
        int middlelist = 0;
        listNumbers = listNumbers.OrderBy(n => n).ToList();
        if (listNumbers.Count % 2 == 0)
        {
            middlelist = listNumbers.Count / 2;
            median = (listNumbers[middlelist] + listNumbers[middlelist - 1]) / 2;

        }
        else
        {       
            middlelist= listNumbers.Count / 2;
            median = (listNumbers[middlelist]);
        }
        return median;
    }
    static double CalculateMode(List<double> listNumbers)
    {
        double mode = listNumbers[0];
        int maxCount = 0;
        for (int i = 0; i < listNumbers.Count; i++)
        {
            int count = 0;
            for (int j = 0; j < listNumbers.Count; j++)
            {
                if (listNumbers[i] == listNumbers[j])
                {
                    count++;
                }
            }
            if (count > maxCount)
            {
                maxCount = count;
                mode = listNumbers[i];
            }
        }
        return mode;
    }
    static double CalculateStandarDeviation(List<double> listNumbers)
    {
        double mean = CalculateAverage(listNumbers), addition = 0, variance = 0, standardDeviation = 0;
        foreach (double number in listNumbers)
        {
            addition += Math.Pow(number - mean, 2);
        }
        variance = addition / listNumbers.Count;
        standardDeviation = Math.Sqrt(variance);
        return standardDeviation;
    }
}


