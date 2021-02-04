using System;
using System.Threading;

namespace ErickDamianPruebaConsoleApp
{
    class Edificio
    {
        public static void ContarPersonas(object obj)
        {
            var nombre = (string)obj;
            var departamentos = 0;
            var personas = 0;
            var personasTotal = 0;
            var random = new Random();
            while (departamentos < 8)
            {
                departamentos += random.Next(0, 8);
                personas += random.Next(0, 6);
                for (int i = 0; i <= departamentos; i++)
                {
                    for (int j = 0; j <= personas; j++)
                    {
                        personasTotal += personas;
                    }
                }
                Console.WriteLine("El {0}, departamento {1}, tiene {2}", nombre, departamentos, personas);
                Thread.Sleep(10);
            }
            Console.WriteLine("En el edificio hay {0} personas", personasTotal);
        }
    }
}
