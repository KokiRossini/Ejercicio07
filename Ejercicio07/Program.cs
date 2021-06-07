using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoMenor;
            int ladoMayor;
            float perimetro;
            float superficie;

            Console.Write("ingrese el lado mayor del rectangulo: ");
            ladoMayor = Convert.ToInt32(Console.ReadLine());
            Console.Write("ingrese el lado menor del rectangulo: ");
            ladoMenor = Convert.ToInt32(Console.ReadLine());

            perimetro = 2 * ladoMayor + 2 * ladoMenor;
            superficie = ladoMayor * ladoMenor;

            Console.Write($"la superficie del rectangulo es {superficie} y el perimetro es {perimetro}.");
            Console.ReadLine();

        }
    }
}
