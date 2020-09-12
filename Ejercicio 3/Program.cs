using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite otro numero");
            int n2 = int.Parse(Console.ReadLine());

            Class1 sum = new Class1();
            sum.suma(n1,n2);

            Class1 rest = new Class1();
            rest.resta(n1, n2);

            Class1 mult = new Class1();
            mult.multi(n1,n2);

            Class1 divi = new Class1();
            divi.div(n1,n2);

            Console.ReadKey();
        }
    }
}
