using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bienvenida();

            //SumarVariables();

            //TryCatchParse();

            //EsPar();

            //Ej78();
            
            Console.ReadKey();
        }

        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static void Bienvenida()
        {
            Console.WriteLine("Hola Bienvenidos!!");
            int resultado = Sumar(5, 6);
            Console.WriteLine(resultado);
        }

        public static void SumarVariables()
        {
            Console.WriteLine("Ingrese un numero");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine("Ingrese otro numero");
            int.TryParse(Console.ReadLine(), out int b);

            if (a == b)
            {
                Console.WriteLine("Si, son iguales");
            }
            else
            {
                Console.WriteLine($"La suma es {Sumar(a, b)}");
            }
        }

        public static void TryCatchParse()
        {
            Console.WriteLine("Ingrese un numero");
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void EsPar()
        {
            int numero = 0;
            Console.WriteLine("Ingrese un numero");
            string palabra = Console.ReadLine();
            while (!int.TryParse(palabra, out numero))
            {
                Console.WriteLine($"Ingreso {palabra} que no es un numero");
                Console.WriteLine("Ingrese un numero");
                palabra = Console.ReadLine();
            }

            if (numero == 0)
            {
                Console.WriteLine("El numero es CERO");
            }
            else if (numero % 2 == 0)
            {
                Console.WriteLine("El numero es PAR");
            }
            else
            {
                Console.WriteLine("El numero es IMPAR");
            }
        }

        public static void Ej78()
        {
            //Del registro de partes meteorológico por cada día se registra la fecha, temperatura
            //máxima y temperatura mínima. Diseñar un algoritmo que permita informar:
            // El día más frío y cual fue esa temperatura
            // El día más cálido y cual fue esa temperatura

            int[] temperaturaMax = new int[30];
            int[] temperaturaMin = new int[30];
            var random = new Random();

            for(int i = 0; i < 30; i++)
            {
                temperaturaMax[i] = random.Next(21, 37);
                temperaturaMin[i] = random.Next(-10, 20);
            }

            int index = 0;
            foreach (var temp in temperaturaMin)
            {
                Console.WriteLine($"Minima: {temp} \t Maxima: {temperaturaMax[index]}");
                index++;
            }

            Console.WriteLine($"La temperatura maxima fue de {temperaturaMax.Max()}");
            Console.WriteLine($"La temperatura minima fue de {temperaturaMin.Min()}");
        }

    }
}
