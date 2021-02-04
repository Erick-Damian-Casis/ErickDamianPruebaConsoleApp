using System;
using System.Threading;

namespace ErickDamianPruebaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread piso1 = new Thread(Edificio.ContarPersonas);
            Thread piso2 = new Thread(Edificio.ContarPersonas);
            Thread piso3 = new Thread(Edificio.ContarPersonas);
            Thread piso4 = new Thread(Edificio.ContarPersonas);
            Thread piso5 = new Thread(Edificio.ContarPersonas);
            Thread piso6 = new Thread(Edificio.ContarPersonas);
            Thread piso7 = new Thread(Edificio.ContarPersonas);
            Thread piso8 = new Thread(Edificio.ContarPersonas);
            Thread piso9 = new Thread(Edificio.ContarPersonas);
            Thread piso10 = new Thread(Edificio.ContarPersonas);
            Thread piso11 = new Thread(Edificio.ContarPersonas);
            Thread piso12 = new Thread(Edificio.ContarPersonas);


            piso1.Start("Piso 1");
            piso2.Start("Piso 2");
            piso3.Start("Piso 3");
            piso4.Start("Piso 4");
            piso5.Start("Piso 5");
            piso6.Start("Piso 6");
            piso7.Start("Piso 7");
            piso8.Start("Piso 8");
            piso9.Start("Piso 9");
            piso10.Start("Piso 10");
            piso11.Start("Piso 11");
            piso12.Start("Piso 12");

            piso1.Join();
            piso2.Join();
            piso3.Join();
            piso4.Join();
            piso5.Join();
            piso6.Join();
            piso7.Join();
            piso8.Join();
            piso9.Join();
            piso10.Join();
            piso11.Join();
            piso12.Join();

        }
    }
}
