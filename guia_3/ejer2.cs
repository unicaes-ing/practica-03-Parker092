using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class ejer2
    {
        public void ejerDos()
        {

            Random num = new Random();
            int numero = num.Next(1, 101);

            if (numero % 2 == 0)
            {
                //par
                Console.WriteLine("Numero Par");
            }
            else
            {
                //impar
                Console.WriteLine("Numero Impar");
            }
            Console.WriteLine("Presione ENTER para continuar...");
            Console.ReadKey();
        }
    }
}
