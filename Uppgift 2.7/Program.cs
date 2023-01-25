using System;
namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv en 2 ord lång mening (utan punkt) ");

            Console.Write("Mening : ");
            string Mening = Console.ReadLine();

            int  MellanslagIndex = Mening.IndexOf(" ");

            string ord1 = Mening[..MellanslagIndex];
            string ord2 = Mening[(MellanslagIndex+1)..];


            Console.WriteLine(ord2 + " " + ord1);
        }


    }

}