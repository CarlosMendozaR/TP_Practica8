using System;

public class Curp
{
    class Curp
    {
        public string CURP;

        private string nombre;
        private string apellidoPat;
        private string apellidoMat;
        private string año;
        private string mes;
        private string dia;
        private string ciudad;
        private char sexo;

        public Curp()
        {

        }

        public void GenerarCurp()
        {
            CURP = apellidoPat[0].ToString();
            foreach (char letra in apellidoPat)
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                    CURP = CURP + letra;
                    break;
                }
            }
            CURP = CURP + apellidoMat[0] + nombre[0] + año + mes + dia + sexo + ciudad;

            foreach (char letra in apellidoPat)
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                }
                else if (letra == apellidoPat[0])
                {

                }
                else
                {
                    CURP = CURP + letra;
                    break;
                }
            }

            foreach (char letra in apellidoMat)
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                }
                else if (letra == apellidoMat[0])
                {

                }
                else
                {
                    CURP = CURP + letra;
                    break;
                }
            }

            foreach (char letra in nombre)
            {
                if (letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
                {
                }
                else if (letra == nombre[0])
                {

                }
                else
                {
                    CURP = CURP + letra;
                    break;
                }
            }
        }

        public void LeerDatos()
        {
            Console.WriteLine("ESCRIBA LOS SIGUIENTES DATOS EN MAYUSCULA:\nEscriba su NOMBRE");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su APELLIDO PATERNO");
            apellidoPat = Console.ReadLine();
            Console.WriteLine("Escriba su APELLIDO MATERNO");
            apellidoMat = Console.ReadLine();
            Console.WriteLine("Escriba su año de nacimineto a dos digitos");
            año = Console.ReadLine();
            Console.WriteLine("Escriba su mes de nacimiento a dos digitos");
            mes = Console.ReadLine();
            Console.WriteLine("Escriba su dia de nacimineto a dos digitos");
            dia = Console.ReadLine();
            Console.WriteLine("Escriba las primeras dos letras de su ciudad natal");
            ciudad = Console.ReadLine();
            Console.WriteLine("Escriba la letra de su sexo H-Hombre o M-Mujer");
            sexo = char.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return CURP;
        }
    }
}
