using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos galones de combustible le quedan al carro?");
            int combust = int.Parse(Console.ReadLine());
            Carro car = new Carro();
            car.Combust = combust;
            otra:
            car.Encender(car.Combust);
            goto otra;
        }
    }
}
