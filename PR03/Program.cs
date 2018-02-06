using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el area de un triangulo
            //y la superficie de un circulo

            double area, labase, laaltura;
            double superficie, radio;
            string resp = "";

            Console.Clear();
            Console.WriteLine("La figura es (C)irculo o (T)riangulo?");
            resp = Console.ReadLine();

            if (resp.ToUpper() == "C")
            {
                Console.WriteLine("Dame el radio");
                radio = double.Parse(Console.ReadLine());
                superficie = Math.PI * Math.Pow(radio, 2);
                Console.WriteLine("La superficie es {0}", superficie);
            }
            else if (resp.ToUpper() == "T")
            {
                Console.WriteLine("Dame la base");
                labase = double.Parse(Console.ReadLine());
                Console.WriteLine("Dame la altura");
                laaltura = double.Parse(Console.ReadLine());
                area = (labase * laaltura) / 2;
                Console.WriteLine("El area es {0}", area);
            }
            else {
                Console.WriteLine("Figura desconocida");
            }
            Console.ReadKey();
        }
    }
}
