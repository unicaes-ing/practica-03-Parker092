using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_3
{
    class Ejer3
    {
        public void ejerTres()
        {
            int num1, num2, num3;
            Console.WriteLine("Ingrese numero 1");
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese numero 2");
            int.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Ingrese numero 3");
            int.TryParse(Console.ReadLine(), out num3);

            if (num1<num2 && num1<num3)
            {
                if (num2<num3)
                { 
                    Console.WriteLine(" Orden menor a mayor: "+num1+" "+num2+" "+num3);
                }
                else
                {
                    Console.WriteLine(" Orden menor a mayor: "+num1+" "+num3+" "+num2);
                }
            }
            else
            {
                if (num2<num3)
                {
                    Console.WriteLine(" Orden menor a mayor: "+num2+" "+num3+" "+ num1);
                }
                else
                {
                    Console.WriteLine(" Orden menor a mayor: "+num3+" "+num2+" "+num1);
                }
            }
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();
        }
    }
}
