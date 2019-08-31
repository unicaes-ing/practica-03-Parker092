using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class Ejer4
    {
        public void ejerCuatro()
        {
            int mins, op;
            decimal total=0.00M;
            Console.WriteLine("Ingrese la cantidad de minutos: ");
            int.TryParse(Console.ReadLine(),out mins);
            Console.WriteLine("* Seleccione Zona *");
            Console.WriteLine("* 3 * Zona Occidental");
            Console.WriteLine("* 4 * Zona Central");
            Console.WriteLine("* 5 * Zona Oriental");
            int.TryParse(Console.ReadLine(), out op);
            switch (op)
            {
                case 1:
                    total = mins * 0.32M;
                    break;
                case 2:
                    total = mins * 0.25M;
                    break;
                case 3:
                    total = mins * 0.36M;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Costo de llamada: " + total.ToString("C2"));
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();
        }
    }
}
