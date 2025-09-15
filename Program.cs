using System;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Channels;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Menu();
        }

        static void Start(uint endTime)
        {
            uint currentTime = 0;

            while (currentTime < endTime)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                currentTime++;
            }

            Console.Clear();
            Console.WriteLine(currentTime);
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1500);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string? userInput = Console.ReadLine().ToLower();

            char type = char.Parse(userInput.Substring(userInput.Length - 1, 1));
            uint time = uint.Parse(userInput.Substring(0, userInput.Length - 1));
            uint multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(uint endTime)
        {
            Console.Clear();
            Console.WriteLine("Preparar...");
            Thread.Sleep(600);

            Console.WriteLine("Pronto...");
            Thread.Sleep(600);

            Console.WriteLine("Iniciar...");
            Thread.Sleep(600);

            Start(endTime);
        }
    }
}