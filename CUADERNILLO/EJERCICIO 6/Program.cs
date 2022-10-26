using System;

namespace EJERCICIO6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Realizar un programa que dado un operario se conoce su sueldo y los años de antigüedad.");
            Console.WriteLine("Realiza un programa que lea los datos de entrada e indicar:");
            Console.WriteLine(" Si el sueldo es igual o inferior a $10000 y su antigüedad es igual o superior a 5 años, otorgarle un aumento del 25 %, mostrar el sueldo a pagar.");
            Console.WriteLine("Si el sueldo es inferior a $10000 pero su antigüedad es menor a 5 años, otorgarle un aumento de 15 %.");
            Console.WriteLine("Si el sueldo es mayor o igual a 10000 mostrar el sueldo.");
            Console.WriteLine("..............................................................................................................");

            double sueldo, sueldoTot, aument;
            int antiguedad;

            Console.Write("Ingrese sueldo del empleado: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su antiguedad en años: ");
            antiguedad = int.Parse(Console.ReadLine());
            if (sueldo <= 10000 && antiguedad >= 5)
            {
                aument = sueldo * 0.25;
                sueldoTot = sueldo + aument;
                Console.Write("Sueldo a pagar:" + sueldoTot);
            }
            else
            {
                if (sueldo < 10000)
                {
                    aument = sueldo * 0.15;
                    sueldoTot = sueldo + aument;
                    Console.Write("Sueldo a pagar:" + sueldoTot);
                }
                else
                {
                    Console.Write("Sueldo a pagar:" + sueldo);
                }
            }
            Console.ReadKey();

        }
    }
}
