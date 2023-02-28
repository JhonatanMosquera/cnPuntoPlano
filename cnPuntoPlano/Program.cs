using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPuntoPlano
{
    /// <summary>
    /// Nombre: Jhonatan Stiven Mosquera Moreno
    /// fecha: 24/02/2023
    /// descripcion: plano cartesiano
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y");
            double y = Convert.ToDouble(Console.ReadLine());
            //llamamos al metodo para saber en que cuadrante se encuentra los valores
            cuadrante(x, y);
            Console.ReadKey();


        }
        //creamos el metodo para saber en que cuadrante se encuentra los datos
        static void cuadrante(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el cuadrante 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Se encuentra en el cuadrante 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Se encuentra en el cuadrante 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("se encuentra en el cuadrante 4");
            }
            else
            {
                Console.WriteLine("Se encuentra en el lugar de origen");
            }
        }

    }
}
