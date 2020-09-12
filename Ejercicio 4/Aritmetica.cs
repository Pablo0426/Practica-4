using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Aritmetica
    {
        public void suma(int n, int n1)
        {
            int result = n + n1;
            Console.WriteLine("El resultado de la suma es " + result + "\n");
        }
        public void suma(int n, int n1, int n2)
        {
            int result = n + n1 + n2;
            Console.WriteLine("El resultado de la suma es " + result + "\n");
        }
        public void suma(int n, int n1, int n2, int n3)
        {
            int result = n + n1 + n2 + n3;
            Console.WriteLine("El resultado de la suma es " + result + "\n");
        }

        public void resta(int n, int n1)
        {
            int result = n - n1;
            Console.WriteLine("El resultado de la resta es " + result + "\n");
        }
        public void resta(int n, int n1, int n2)
        {
            int result = n - n1 - n2;
            Console.WriteLine("El resultado de la resta es " + result + "\n");
        }
        public void resta(int n, int n1, int n2,int n3)
        {
            int result = n - n1 - n2 - n3;
            Console.WriteLine("El resultado de la resta es " + result + "\n");
        }
    }
}
