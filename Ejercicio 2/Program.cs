using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la 1ra nota del estudiante");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la 2da nota del estudiante");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la 3ra nota del estudiante");
            int n3 = int.Parse(Console.ReadLine());

            Class1 class1 = new Class1();
            class1.cal(n1, n2, n3);

            Console.ReadKey();
        }
    }
}
