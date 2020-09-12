using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Personaje
    {
        public void up(string p)
        {
            Console.WriteLine(p+" se mueve hacia arriba");
        }
        public void right(string p)
        {
            Console.WriteLine(p + " se mueve hacia la derecha");
        }
        public void left(string p)
        {
            Console.WriteLine(p + " se mueve hacia la izquierda");
        }
        public void down(string p)
        {
            Console.WriteLine(p + " se mueve hacia abajo\n");
        }
    }

}
