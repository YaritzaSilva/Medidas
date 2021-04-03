using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double metros, centimetros, quilometros;

            Console.Beep();
            Console.WriteLine("---------");
            Console.Write("Digite a medida (em metros): ");
            entrada = Console.ReadLine();
            metros = Convert.ToDouble(entrada);
            centimetros = metros * 100;
            quilometros = metros / 1000;

            Console.Beep();
            Console.WriteLine("----------");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.WriteLine("\n---Equivalencia---");
            Console . ResetColor ();
            Console.WriteLine($"{centimetros:N2} cm");
            Console.WriteLine($"{metros:N1} m");
            Console.WriteLine($"{quilometros:N3} km");
            Console.WriteLine("----------");
        }
    }
}
