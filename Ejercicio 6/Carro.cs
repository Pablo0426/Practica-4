using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Carro
    {
        private int combust;
        public int Combust
        {
            get
            {
                return combust;
            }
            set
            {
                combust = value;
            }
        }
        public void Encender(int C)
        {
            if (Combust == 0)
            {
                Console.WriteLine("El carro no puede avanzar por falta de combustible...");
                Console.ReadKey();
            }
            else
            {
                Combust = Combust - 1;
                Console.WriteLine("El carro esta avanzando! Ahora solo quedan "+Combust+" galones...");
                Console.ReadKey();
            }
        }
    }
}
