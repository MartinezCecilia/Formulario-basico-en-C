using System;

namespace Formulario_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            String Nombre, ApellidoPaterno, ApellidoMaterno, Ocupacion, Correo, Telefono;
            int Edad;

            Console.WriteLine("REGISTRO EN EL FORMULARIO");
            Console.WriteLine("Ingresa tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido paterno: ");
            ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu apellido materno: ");
            ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu ocupacion: ");
            Ocupacion = Console.ReadLine();

            Console.WriteLine("Ingresa tu correo electronico: ");
            Correo = Console.ReadLine();

            Console.WriteLine("Ingresa tu numero celular: ");
            Telefono = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            if (Edad < 18)
            {
                Console.WriteLine("Registro fallido, el usuario es menor de edad");
            }
             
            {
                Console.WriteLine(Nombre);
                Console.WriteLine(ApellidoPaterno);
                Console.WriteLine(ApellidoMaterno);
                Console.WriteLine(Ocupacion);
                Console.WriteLine(Correo);
                Console.WriteLine(Telefono);

            }


        }
    }
}

