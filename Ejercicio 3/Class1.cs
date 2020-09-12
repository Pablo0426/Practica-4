using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Class1
    {
        public void suma(int n, int n1)
        {
            int result = n + n1;
            Console.WriteLine("El resultado de la suma es "+ result+"\n");
        }
        public void resta(int n, int n1)
        {
            int result = n - n1;
            Console.WriteLine("El resultado de la resta es " + result + "\n");
        }
        public void multi(int n, int n1)
        {
            int result = n * n1;
            Console.WriteLine("El resultado de la multiplicacion es " + result + "\n");
        }
        public void div(int n, int n1)
        {
            int result = n / n1;
            Console.WriteLine("El resultado de la division es " + result);
        }

    }
}
