using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCsharp1
{
    internal class Practica1
    {
        static void Main(string[] args)
        {
            // int, string, bool, double, char
            int cal1 = 0;
            int cal2, cal3, resultado;
            string dato1;

            Console.WriteLine("Ingresa primera calificacion: ");
            dato1 = Console.ReadLine();
            cal1 = Convert.ToInt32(dato1);

            Console.WriteLine("Ingresa segunda calificacion: ");
            dato1 = Console.ReadLine();
            cal2 = Convert.ToInt32(dato1);

            int suma = cal1 + cal2;
            Console.WriteLine("La suma de las calificaciones es: " + suma);

            if (cal1 > cal2)
            {
                Console.WriteLine("La nota mayor es: " + cal1);
            }
            else
            {
                Console.WriteLine("La nota mayor es: " + cal2);
            }

            // While
            int x;
            x = 1;

            while (x <= 100)
            {
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }

            //do while
            int y = 1;
            do
            {
                Console.Write(y);
                Console.Write(" - ");
                y++;
            } while (y <= 100);
            //For
            int f;
            for (f = 0; f < 100; f++)
            {
                Console.Write(f);
                Console.Write(" - ");
            }
        }
    }
}