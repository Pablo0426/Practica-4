using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mario bro = new Mario();
            bro.P = "Mario";
            bro.up(bro.P);
            bro.right(bro.P);
            bro.left(bro.P);
            bro.down(bro.P);

            Koopa malo = new Koopa();
            malo.P = "Bowser";
            malo.up(malo.P);
            malo.right(malo.P);
            malo.left(malo.P);
            malo.down(malo.P);
           
            Console.ReadKey();


        }
    }
}
