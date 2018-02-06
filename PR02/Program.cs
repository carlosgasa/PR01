using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            int horastrabajadas = 0;
            float tasaimpuesto = 0, pagoxhora = 0;
            float pagobruto = 0, pagoimpuesto = 0, pagoneto = 0;
            Console.Clear();
            // Borra la pantalla
            Console.WriteLine("El siguiente porgrama calcula el salario de un trabajador");
            Console.WriteLine();
            // Leer datos de entrada
            Console.Write("Introduce las horas trabajadas: ");
            horastrabajadas = int.Parse(Console.ReadLine());
            Console.Write("Introduce la tasa de impuesto: ");
            tasaimpuesto = float.Parse(Console.ReadLine());
            Console.Write("Introduce el pago por hora: ");
            pagoxhora =float.Parse(Console.ReadLine());
            // Realizar el calculo
            pagobruto = (horastrabajadas * pagoxhora);
            pagoimpuesto = (pagobruto * tasaimpuesto);
            pagoneto = ( pagobruto - pagoimpuesto);
            // Imprimir salida en pantalla
            Console.WriteLine();
            Console.WriteLine("El pago bruto es = { 0} ", pagobruto);
            Console.WriteLine("El pago por impuesto es = { 0}", pagoimpuesto);
            Console.WriteLine("El pago neto es = { 0}", pagoneto);
            Console.ReadLine();
        }
    }
}
