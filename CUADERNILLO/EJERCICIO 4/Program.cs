using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precio_agua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alto, largo, ancho,TOTAL;
            double Can_m,P_m=45, P_TOTAL;
            Console.WriteLine("CALCULAR LOS METROS CUBICOS DE UNA SISTERNA");
            Console.WriteLine("INGRESE LA CANTIDAD DE METROS DE ALTO");
            alto= double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CATIDAD DE METROS DE LARGO");
            largo= double.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CANTIDAD DE METROS DEL ANCHO");
            ancho = double.Parse(Console.ReadLine());

            {
                TOTAL = (alto * largo * ancho);
            }
            Console.WriteLine("EL TOTAL DE METROS CUBICOS SON : "   + TOTAL + " M3 ");

            Console.WriteLine("INGRESE LA CANTIDAD DE METROS CUBICO DE AGUA");
            Can_m= double.Parse(Console.ReadLine());

            {
                P_TOTAL = (P_m * Can_m);
            }

            Console.WriteLine("LA CANTIDAD A PAGAR PARA LLENAR SU DEPOSITO DE AGUA ES DE  : "+P_TOTAL);
            Console.ReadKey();

        }
    }
}
