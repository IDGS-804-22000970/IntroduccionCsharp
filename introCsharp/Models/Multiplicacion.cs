using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introCsharp.Models
{
    public class Multiplicacion
    {
        public int A { get; set; }

        public int B { get; set; }

        public int Res { get; set; }

        public string Operacion { get; set; }

        public void Multiplicar()
        {
            int resultado = 0;

            string suma = "";

            for (int i = 0; i < B; i++)
            {
                resultado = resultado + A;

                suma += A.ToString();

                if (i < B - 1)
                {
                    suma += "+";
                }
            }

            suma += "=" + resultado;

            this.Res = resultado;

            this.Operacion = suma;
        }
    }
}