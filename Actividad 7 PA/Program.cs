// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

class Program 
{
    
    static void Main(string[] args)
    {
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
                        List<int> enterNumbers = NumbersList();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
    static List<int> NumbersList()
    {
        Console.Clear();
        List<int> listNumbers = new List<int>();
        Console.WriteLine("--- Ingresar números ---");
        Console.Write("¿Cuántos números desea ingresar?: ");
        int size = int.Parse(Console.ReadLine());
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Ingrese el No.{i+1}: ");
            int number = int.Parse(Console.ReadLine());
            listNumbers.Add(number);
    
        }
        Console.WriteLine("\nHa ingresado los números correctamente");
        Console.WriteLine("Presione enter para continuar...");
        Console.ReadKey();
        return listNumbers;
    }

    
}


