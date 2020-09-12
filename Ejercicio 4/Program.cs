using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            int n4 = int.Parse(Console.ReadLine());

            Aritmetica sum = new Aritmetica();
            sum.suma(n1, n2);
            sum.suma(n1, n2, n3);
            sum.suma(n1, n2, n3, n4);

            Aritmetica rest = new Aritmetica();
            rest.resta(n1, n2);
            rest.resta(n1, n2, n3);
            rest.resta(n1, n2, n3, n4);

            Console.ReadKey();
        }
    }
}
