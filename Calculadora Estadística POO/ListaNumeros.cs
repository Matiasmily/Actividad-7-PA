using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Estadística_POO
{
    public class ListaNumeros
    {
        public List<double> NumbersList {  get; set; }

        public ListaNumeros(List<double> numbersList)
        {
            NumbersList = numbersList;
        }

        public void ShowMenu()
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
        public void EnterNumbersList()
        {

            Console.Clear();
            NumbersList.Clear();
            Console.WriteLine("--- Ingresar números ---");
            Console.Write("¿Cuántos números desea ingresar?: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ingrese el No.{i + 1}: ");
                double number = double.Parse(Console.ReadLine());
                NumbersList.Add(number);

            }
            Console.WriteLine("\nHa ingresado los números correctamente");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();


        }

        public double CalculateAverage()
        {
            double average = 0, addition = 0;
            foreach (double number in NumbersList)
            {
                addition += number;
            }
            average = addition / NumbersList.Count();
            return average;
        }
        public double CalculateMedian()
        {
            double median = 0;
            int middlelist = 0;
            NumbersList = NumbersList.OrderBy(n => n).ToList();
            if (NumbersList.Count % 2 == 0)
            {
                middlelist = NumbersList.Count / 2;
                median = (NumbersList[middlelist] + NumbersList[middlelist - 1]) / 2;

            }
            else
            {
                middlelist = NumbersList.Count / 2;
                median = (NumbersList[middlelist]);
            }
            return median;
        }
        public double CalculateMode()
        {
            double mode = NumbersList[0];
            int maxCount = 0;
            for (int i = 0; i < NumbersList.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < NumbersList.Count; j++)
                {
                    if (NumbersList[i] == NumbersList[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = NumbersList[i];
                }
            }
            return mode;
        }
        public double CalculateStandarDeviation()
        {
            double mean = CalculateAverage(), addition = 0, variance = 0, standardDeviation = 0;
            foreach (double number in NumbersList)
            {
                addition += Math.Pow(number - mean, 2);
            }
            variance = addition / NumbersList.Count;
            standardDeviation = Math.Sqrt(variance);
            return standardDeviation;
        }
    }

}
