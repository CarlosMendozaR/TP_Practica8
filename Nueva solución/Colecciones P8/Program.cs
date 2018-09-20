using System;
using System.Collections;

namespace Colecciones_P8
{
    class Program
    {
        static void Main()
        {
            Curp c1 = new Curp();
            Curp c2 = new Curp();
            Curp c3 = new Curp();
            Curp c4 = new Curp();

            c1.LeerDatos();
            c1.GenerarCurp();
            Console.WriteLine(c1);

            ArrayList Curps = new ArrayList();
            Curps.Add(c1);


            Console.ReadLine();
        }
    }
}
