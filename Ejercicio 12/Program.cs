using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ejercicio 12. Crea un programa que permita ingresar los nombres de 5 empleados y sus sueldos respectivos.
             * El programa debe mostrar el sueldo mayor y el nombre del empleado al que pertenece. 
             */

            // Vector para almacenar los nombres de los empleados
            string[] nombreEmpleado = new string[5];

            // Vector para almacenar los sueldos de los empleados
            double[] sueldoEmpleado = new double[5];

            // Bucle para ingresar los nombres y sueldos de los empleados
            for (int i = 0; i < nombreEmpleado.Length; i++)
            {
                // Solicita el nombre del empleado
                Console.WriteLine("Escribe el nombre del empleado" + (i + 1) + ":");
                nombreEmpleado[i] = Console.ReadLine();

                // Solicita el sueldo del empleado, validando que sea mayor que 0
                do
                {
                    Console.WriteLine("Escribe el sueldo (mayor que 0) del empleado" + (i + 1) + ":");
                    sueldoEmpleado[i] = double.Parse(Console.ReadLine());
                } while (sueldoEmpleado[i] <= 0); // Repite mientras el sueldo no sea válido
            }

            // Variable para almacenar la posición del empleado con el sueldo más alto
            int posición = 0;

            // Bucle para encontrar el sueldo más alto
            for (int i = 0; i < sueldoEmpleado.Length; i++)
            {
                // Compara el sueldo actual con el sueldo almacenado como máximo
                if (sueldoEmpleado[i] > sueldoEmpleado[posición])
                {
                    posición = i; // Actualiza la posición si se encuentra un sueldo mayor
                }
            }

            // Muestra el nombre y el sueldo del empleado con el salario más alto
            Console.WriteLine("El empleado " + nombreEmpleado[posición] + " tiene el salario máximo: " + sueldoEmpleado[posición] + " euros.");

        }
    }
}
