using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Cargar
    {
        private string[] nombre;
        private float[] sueldos;
        public void CargarMetodo()
        {
            nombre = new string[5];
            sueldos = new float[5];
            for(int u =0; u < nombre.Length; u++)
            {
                Console.WriteLine("\nIngresar el nombre del empleado " + (u + 1) + ":");
                nombre[u] = Console.ReadLine();
                Console.WriteLine("\nIngresar  el sueldo del empleado " + (u + 1) + ":");
                string lni;
                lni = Console.ReadLine();
                sueldos[u] = float.Parse(lni);
                Console.Clear();
            }
        }

        public void mayor()
        {
            float mayorr;
            int s;
            mayorr = sueldos[0];
            s = 0;
            for(int u =1; u< nombre.Length; u++)
            {
                if(sueldos[u] > mayorr)
                {
                    mayorr = sueldos[u];
                    s = u;
                }
            }
            Console.WriteLine("El empleado con el mayor sueldo es: " + nombre[s] + "con un sueldo superior a los demas de: " + mayorr);
            Console.ReadKey();
          }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Cargar result = new Cargar();
            result.CargarMetodo();
            result.mayor();
        }
    }
}