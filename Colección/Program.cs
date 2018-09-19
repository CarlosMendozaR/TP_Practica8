using System;
using System.Collections;

namespace Colección
{
    class Program
    {
        static void Main()
        {
            ArrayList persona = new ArrayList();
            Console.WriteLine("Para crear un nuevo CURP, introduzca los datos que se le solicitan en mayúscula.\nPRIMER NOMBRE:");
            persona.Add(Console.ReadLine());
            Console.WriteLine("APELLIDO:");
            persona.Add(Console.ReadLine());
            Console.WriteLine("AÑO DE NACIMIENTO:");
            persona.Add(Console.ReadLine());
            Console.WriteLine("MES:");
            persona.Add(Console.ReadLine());
            Console.WriteLine("DÍA:");
            persona.Add(Console.ReadLine());
            Console.WriteLine("ESTADO (Primeras dos letras):");
            persona.Add(Console.ReadLine());
            Console.WriteLine("SEXO (H ó M):");
            persona.Add(Console.ReadLine());



        }
    }
}
