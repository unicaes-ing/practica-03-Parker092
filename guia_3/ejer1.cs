using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class ejer1
    {
        public void ejerUno()
        {
            int cMin, cSegs;
            int hora;
            Console.WriteLine("Ingrese horas: (hh)");
            hora = Convert.ToInt32(Console.ReadLine());

            if (hora > 0)
            {
                cMin = hora / 60;
                cSegs = hora / 3600;

                Console.WriteLine("la cantidad de horas:" + hora + "equivale a " + cMin + " minutos y " + cSegs + " segundos.");
            }
            else
            {
                if (hora < 0)
                {
                    Console.WriteLine("Formato de hores es negativo.");
                }
            }
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadKey();
        }
    }
}
