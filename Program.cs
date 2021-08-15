using System;

namespace U2EA
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializamos las variables
            String primerNombre, apellidoPaterno, apellidoMaterno;

            // pedimos al usuario el valor de las variables
            Console.Write("\nIngresa tu primer nombre: ");
            primerNombre = Console.ReadLine();

            Console.Write("Ingresa tu apellido patero: ");
            apellidoPaterno = Console.ReadLine();

            Console.Write("Ingresa tu apellido materno: ");
            apellidoMaterno = Console.ReadLine();

            // llamamos a los métodos para obtener el texto procesado
            String correo = generarCorreo(primerNombre, apellidoPaterno, apellidoMaterno);
            String clave = generarClave(primerNombre, apellidoPaterno, apellidoMaterno);

            mostrarResultado(primerNombre, apellidoPaterno, apellidoMaterno, correo, clave);

        }

        private static String generarCorreo(
            String primerNombre, 
            String apellidoPaterno, 
            String apellidoMaterno)
        {
            return primerNombre + "." + apellidoMaterno[0] + apellidoPaterno[0] + "@correo.com";
        }

        private static String generarClave(
            String primerNombre, 
            String apellidoPaterno, 
            String apellidoMaterno)
        {
            // inicializamos la variable donde se guardará la clave
            // ingresamos las primeras 2 letrs del primer nombre
            String temp = primerNombre.ToUpper().Substring(0,2);

            // recuperamos el último caracter del apellido materno en minúsculas
            char lastLeter =  char.Parse(apellidoMaterno.ToLower().Substring(apellidoMaterno.Length -1));

            // concatenamos el código ascii de último caracter del appellido materno en minúsculas
            temp += System.Convert.ToInt32(lastLeter).ToString();

            // concatenamos la primera letra del apellido paterno en minúsculas
            // más la última letra del apellido paterno en mayúsculas
            temp += apellidoPaterno.ToLower()[0] + 
                    apellidoPaterno.ToUpper().Substring(apellidoPaterno.Length -1);
            return temp;
        }

        private static void mostrarResultado(
            String primerNombre, 
            String apellidoPaterno, 
            String apellidoMaterno, 
            String correo, 
            String clave)
        {
           Console.WriteLine("\n\tNombre: {0} {1} {2} \n\tCorreo: {3} \n\tClave: {4}", 
                primerNombre, 
                apellidoPaterno, 
                apellidoMaterno, 
                correo, 
                clave); 
        }
    }
}
