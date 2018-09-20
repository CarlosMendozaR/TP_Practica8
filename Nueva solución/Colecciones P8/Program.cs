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
            Console.ReadKey();
            Console.Clear();
            
            c2.LeerDatos();
            c2.GenerarCurp();
            Console.WriteLine(c2);
            Console.ReadKey();
            Console.Clear();

            c3.LeerDatos();
            c3.GenerarCurp();
            Console.WriteLine(c3);
            Console.ReadKey();
            Console.Clear();


            c4.LeerDatos();
            c4.GenerarCurp();
            Console.WriteLine(c4);
            Console.ReadKey();
            Console.Clear();


            ArrayList Curps = new ArrayList();
            Curps.Add(c1);
            Curps.Add(c2);
            Curps.Add(c3);
            Curps.Add(c4);

            bool cond = false;
            do
            {
                Console.WriteLine("La lista de CURPS es la siguiente");
                for (int i = 0; i < 4; i++)
                {
                    string cur = Curps[i].ToString();
                    Console.WriteLine("{0}.- \t {1}", i, cur);
                }

                Console.WriteLine("Desea eliminar alguno \n 1) Si \n 2)No");
                int des = int.Parse(Console.ReadLine());
                if (des == 1)
                {
                    Console.WriteLine("Qué curp desea borrar");
                    int borrar = int.Parse(Console.ReadLine());
                    Curps.Remove(borrar);
                    cond = true;
                }
                else
                {
                    cond = false;
                }

                Console.WriteLine("La lista de CURPS es la siguiente");
                for (int i = 0; i < 4; i++)
                {
                    string cur = Curps[i].ToString();
                    Console.WriteLine("{0}.- \t {1}", i, cur);
                }
            }
            while (cond == true);


            Console.ReadLine();
        }
    }
}
