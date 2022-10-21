using System;

namespace L13_EBEAM_1200922
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adultos = new string[5];
            int[] edad = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese el Nombre de una persona : " + (i+1));
                adultos[i] =  (Console.ReadLine());
                Console.WriteLine("Ingrese la edad de esa persona: " + (i+1));
                edad[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
              
                if (edad[i]>18)
                {
                    Console.WriteLine("El nombre de esa persona es : " + adultos[i]);
                    Console.WriteLine("La edad de esa persona: " + edad[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
