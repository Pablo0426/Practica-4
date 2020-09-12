using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba tres caracteristicas de una mesa");
            string caract1 = Console.ReadLine();
            string caract2 = Console.ReadLine();
            string caract3 = Console.ReadLine();
            
            Console.WriteLine("\nEscriba tres caracteristicas de un carro");
            string cat1 = Console.ReadLine();
            string cat2 = Console.ReadLine();
            string cat3 = Console.ReadLine();
            
            Console.WriteLine("\nEscriba tres caracteristicas de una casa");
            string carac1 = Console.ReadLine();
            string carac2 = Console.ReadLine();
            string carac3 = Console.ReadLine();

            Console.Clear();

            Class1 mesa = new Class1();
            mesa.mesa(caract1, caract2, caract3);
            Console.WriteLine("\n");

            Class1 car = new Class1();
            car.carro(cat1, cat2, cat3);
            Console.WriteLine("\n");

            Class1 casa = new Class1();
            casa.casa(carac1, carac2, carac3);

            Console.ReadKey();
        }
    }
}
