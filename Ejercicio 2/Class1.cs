using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Class1
    {
        private int promedio;
        public int Promedio
        {
            get
            {
                return promedio;
            }
            set
            {
                promedio = value;
            }
        }
        public void cal(int n, int n1, int n2)
        {
            Promedio = (n + n1 + n2) / 3;
            if (Promedio > 100)
            {
                Console.WriteLine("Ese promedio no es valido");
            }
            else
            {
                Console.WriteLine("El estudiante tiene un promedio de " + Promedio);
            }
        }
    }
}
