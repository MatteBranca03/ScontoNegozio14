using System;

namespace ConvenienzaNegozzi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il prezzo del primo prodotto");
            double p1 = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il prezzo del secondo prodotto");
            double p2 = double.Parse(Console.ReadLine());
            double sconto;
            double scontato;
            double totale;
            if (p1 > p2)
            {
                sconto = p2 / 100 * 50;
                scontato = p2 - sconto;
                totale = p1 + scontato;
                Console.WriteLine($"lo sconto è di {sconto} euro e il prezzo da pagare è {totale} euro");
            }
            else
            {
                sconto = p1 / 100 * 50;
                scontato = p1 - sconto;
                totale = p2 + scontato;
                Console.WriteLine($"lo sconto è di {sconto} euro e il prezzo da pagare è {totale} euro");
            }
            Console.ReadLine();
        }
    }
}
