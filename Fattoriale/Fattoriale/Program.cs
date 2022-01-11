using System;

namespace Fattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero e avrai il suo fattoriale.");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n - 1; i > 0; i--)
                n = n * i;
            Console.WriteLine(n);

        }
    }
}
